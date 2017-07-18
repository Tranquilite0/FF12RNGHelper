using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FF12RNGHelper
{
    public partial class FormMain : Form
    {
        IRNG searchRNG;
        IRNG dispRNG;
        UInt64 index;
        CircularBuffer<UInt32> searchBuff;
        List<UInt32> healVals;
        double level;
        double mag;
        uint spell;
        double serenityMult;
        enum Spells : uint {Cure=20,Cura=45, Curaga=85, Curaja=145, CuraIZJS=46, CuragaIZJS=86, CurajaIZJS=120 }
        System.Diagnostics.Stopwatch aStopwatch = new System.Diagnostics.Stopwatch();

        public FormMain()
        {
            InitializeComponent();

            cbSpellPow.SelectedIndex = 0;
            cbPlatform.SelectedIndex = 0;
            healVals = new List<UInt32>();
            searchRNG = new RNG1998();
            dispRNG = new RNG1998();
            toolStripStatusLabelPercent.Text = "";
            toolStripStatusLabelProgress.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void parseThings()
        {
            //Parse the boxes
            level = double.Parse(tbLevel.Text);
            mag = double.Parse(tbMagic.Text);
            switch (cbSpellPow.SelectedIndex)
            {
                case 0:
                    spell = (uint)Spells.Cure;
                    break;
                case 1:
                    spell = (uint)Spells.Cura;
                    break;
                case 2:
                    spell = (uint)Spells.Curaga;
                    break;
                case 3:
                    spell = (uint)Spells.Curaja;
                    break;
                case 4:
                    spell = (uint)Spells.CuraIZJS;
                    break;
                case 5:
                    spell = (uint)Spells.CuragaIZJS;
                    break;
                case 6:
                    spell = (uint)Spells.CurajaIZJS;
                    break;
                default:
                    spell = (uint)Spells.Cure;
                    break;
            }
            if (chkbSerenity.Checked)
            {
                serenityMult = 1.5;
            }
            else serenityMult = 1;
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            btnContinue.Enabled = true;
            //Parse the boxes
            parseThings();
            
            healVals.Clear();
            searchBuff = new CircularBuffer<UInt32>(100);
            searchRNG.sgenrand();
            searchBuff.Add(searchRNG.genrand());
            index = 0;
            if (!findNext(UInt32.Parse(tbLastHeal.Text)))
            {
                btnContinue.Enabled = false;
                MessageBox.Show("Impossible Heal Value entered.");
                return;
            }
            displayRNG(index, index + 500);
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            DateTime begint = DateTime.Now;
            if(!findNext(UInt32.Parse(tbLastHeal.Text)))
            {
                MessageBox.Show("Impossible Heal Value entered.");
                return;
            }
            DateTime endt = DateTime.Now;
            toolStripStatusLabelPercent.Text = (endt - begint).ToString();
            displayRNG(index-(ulong)healVals.Count+1, index + 500);
        }

        private bool findNext(UInt32 value)
        {
            //Do a range check before trying this out to avoid entering an infinite loop.
            if(value > healMax() || value < healMin())
            {
                return false;
            }
            healVals.Add(value);
            searchBuff.Add(searchRNG.genrand());
            index++;
            bool match;
            do
            {
                match = true;
                for (int i = 0; i < healVals.Count; i++)
                {
                    if (randToHeal(searchBuff[index - (ulong)i]) != healVals[healVals.Count - 1 - i])
                    {
                        match = false;
                        break;
                    }
                }
                if(!match)
                {
                    searchBuff.Add(searchRNG.genrand());
                    index++;
                }
            } while (!match);
            return true;
        }

        UInt32 randToHeal(UInt32 toConvert)
        {
            double healAmount = (spell + (toConvert % (spell * 12.5)) / 100) * (2 + mag * (level + mag) / 256) * serenityMult;
            return (UInt32)healAmount;
        }

        UInt32 healMax()
        {
            return (UInt32)(spell * 1.125 * (2 + mag * (level + mag) / 256) * serenityMult);
        }

        UInt32 healMin()
        {
            return (UInt32)(spell * (2 + mag * (level + mag) / 256) * serenityMult);
        }

        UInt32 randToPercent(UInt32 toConvert)
        {
            return toConvert % 100;
        }

        private void displayRNG(UInt64 end)
        {
            displayRNG(0, end);
        }

        private void displayRNG(UInt64 start, UInt64 end)
        {
            IRNG displayRNG;
            if(cbPlatform.SelectedItem as string == "PS2")
            {
                displayRNG = new RNG1998();
            }
            else
            {
                displayRNG = new RNG2002();
            }
            //Clear datagridview
            dataGridView1.Rows.Clear();
            //Consume RNG seeds before our desired index
            //This can take obscene amounts of time.
            DateTime startt = DateTime.Now;
            for (UInt64 i = 0; i < start; i++)
            {
                displayRNG.genrand();
            }
            DateTime endtt = DateTime.Now;
            toolStripStatusLabelPercent.Text = (endtt - startt).Milliseconds.ToString();
            for (UInt64 i = start; i < end; i++)
            {
                //Start actually displaying
                UInt32 aVal = displayRNG.genrand();
                dataGridView1.Rows.Add();
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = i;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value = aVal;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2].Value = randToHeal(aVal);
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[3].Value = randToPercent(aVal);
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[4].Value = (aVal < 0x1000000) ;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[5].Value = stealCompute(aVal, displayRNG, false);
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[6].Value = stealCompute(aVal, displayRNG, true);
            }
        }

        
        private string stealCompute(uint currentVal, IRNG anRNG, bool thiefCuff)
        {
            string returnStr = "";
            //Lazy way of looking ahead in the RNG. Probably adds some overhead to the display function.
            RNGState rngState = anRNG.saveState();
            uint firstPercent = currentVal % 100;
            uint secondPercent = anRNG.genrand() % 100;
            uint thirdPercent = anRNG.genrand() % 100;
            anRNG.loadState(rngState);
            if(thiefCuff)
            {
                if(firstPercent < 6)
                {
                    returnStr += "Rare";
                }
                if(secondPercent < 30)
                {
                    returnStr += " + Uncommon";
                }
                if(thirdPercent < 80)
                {
                    returnStr += " + Common";
                }
            }
            else
            {
                if(firstPercent < 3)
                {
                    returnStr = "Rare";
                }
                else if(secondPercent < 10)
                {
                    returnStr = "Uncommon";
                }
                else if(thirdPercent < 55)
                {
                    returnStr = "Common";
                }
            }
            if (returnStr == "")
            {
                returnStr = "None";
            }
            return returnStr.TrimStart(new char[]{' ','+'});
        }
        private void tbLevel_Validating(object sender, CancelEventArgs e)
        {
            double tempVal;
            if(!double.TryParse(tbLevel.Text,out tempVal))
            {
                tbLevel.Text = "0";
            }
        }

        private void tbMagic_Validating(object sender, CancelEventArgs e)
        {
            double tempVal;
            if (!double.TryParse(tbMagic.Text, out tempVal))
            {
                tbMagic.Text = "0";
            }
        }

        private void tbPosition_Validating(object sender, CancelEventArgs e)
        {
            ulong tempVal;
            if (!ulong.TryParse(tbPosition.Text, out tempVal))
            {
                tbPosition.Text = "0";
            }
        }

        private void tbNumDisp_Validating(object sender, CancelEventArgs e)
        {
            ulong tempVal;
            if (!ulong.TryParse(tbNumDisp.Text, out tempVal))
            {
                tbNumDisp.Text = "0";
            }
        }

        private void tbLastHeal_Validating(object sender, CancelEventArgs e)
        {
            UInt32 tempVal;
            if (!UInt32.TryParse(tbLastHeal.Text, out tempVal))
            {
                tbLastHeal.Text = "0";
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            btnGo.Enabled = false;
            aStopwatch.Restart();
            dispRNG.sgenrand();
            parseThings();
            ulong position = ulong.Parse(tbPosition.Text);
            Tuple<ulong, ulong> inputArgs = new Tuple<ulong, ulong>(position, position + ulong.Parse(tbNumDisp.Text));
            backgroundWorkerConsume.RunWorkerAsync(inputArgs);
            //displayRNG(position, position + ulong.Parse(tbNumDisp.Text));
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FF12 RNG Helper v1.02\nSo many features, so little time...");
        }

        private void backgroundWorkerConsume_DoWork(object sender, DoWorkEventArgs e)
        {
            //Start the party!
            Tuple<ulong,ulong> inputArgs = (Tuple<ulong, ulong>)e.Argument;
            BackgroundWorker bw = sender as BackgroundWorker;
            dispRNG.consumeBG(inputArgs.Item1, bw, e);
            if(bw.CancellationPending)
            {
                e.Cancel = true;
            }
            else
            {
                e.Result = inputArgs;
                aStopwatch.Stop();
            }
            
        }

        private void backgroundWorkerConsume_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                //We made it!
                dataGridView1.Rows.Clear();
                Tuple<ulong, ulong> inputArgs = (Tuple<ulong, ulong>)e.Result;
                
                for (UInt64 i = inputArgs.Item1; i < inputArgs.Item2; i++)
                {
                    //Start actually displaying
                    UInt32 aVal = dispRNG.genrand();
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = i;
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value = aVal;
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2].Value = randToHeal(aVal);
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[3].Value = randToPercent(aVal);
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[4].Value = (aVal < 0x1000000);
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[5].Value = stealCompute(aVal, dispRNG, false);
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[6].Value = stealCompute(aVal, dispRNG, true);

                }
            }
            btnGo.Enabled = true;
        }

        private void backgroundWorkerConsume_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripProgressBarPercent.Value = e.ProgressPercentage;
            toolStripStatusLabelPercent.Text = e.ProgressPercentage.ToString() + "%";
            toolStripStatusLabelProgress.Text = aStopwatch.Elapsed.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            backgroundWorkerConsume.CancelAsync();
        }

        private void cbPlatform_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(cbPlatform.SelectedItem as string == "PS2" && searchRNG is RNG2002)
            {
                btnContinue.Enabled = false;
                dataGridView1.Rows.Clear();
                dispRNG = new RNG1998();
                searchRNG = new RNG1998();
            }
            else if(cbPlatform.SelectedItem as string == "PS4" && searchRNG is RNG1998)
            {
                btnContinue.Enabled = false;
                dataGridView1.Rows.Clear();
                dispRNG = new RNG2002();
                searchRNG = new RNG2002();
            }
        }
    }

    //Fairly basic circular buffer. The last thing I want to do is run out of memory while churning through random numbers.
    public class CircularBuffer<T>
    {
        private T[] buffer;
        private int nextFree;

        public CircularBuffer(int length)
        {
          buffer = new T[length];
          nextFree = 0;
        }

        public void Add(T o)
        {
          buffer[nextFree] = o;
          nextFree = (nextFree+1) % buffer.Length;
        }
        public T this[long index]
        {
            get
            {
                int tempIndex = (int)(index % buffer.Length);
                //Make negative indexes behave properly.
                if(tempIndex < 0)
                {
                    tempIndex = buffer.Length + tempIndex;
                }
                return buffer[tempIndex];
            }
            set
            {
                buffer[index % buffer.Length] = value;
            }
        }
        public T this[ulong index]
        {
            get
            {

                return buffer[index % (ulong)buffer.LongLength];
            }
            set
            {
                buffer[index % (ulong)buffer.Length] = value;
            }
        }
    }
    public static class MyExtensions
    {
        ////I dont feel like adding this to the RNG class because that class is supposed to be a direct port. So I guess I will add this extension method.
        //public static void consumeBG(this FF12RNGHelper.RNG rng, ulong amount, BackgroundWorker worker, DoWorkEventArgs e)
        //{
        //    System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
        //    timer.Start();
        //    for (ulong i = 0; i < amount; i++)
        //    {
        //        if (worker.CancellationPending)
        //        {
        //            e.Cancel = true;
        //            break;
        //        }
        //        else
        //        {
        //            rng.genrand();
        //            if (timer.ElapsedMilliseconds > 300)
        //            {
        //                timer.Restart();
        //                worker.ReportProgress((int)((float)i / (float)amount * 100));
        //            }
        //        }
        //    }
        //    worker.ReportProgress(100);
        //}

        //I dont feel like adding this to the RNG2K2 class because that class is supposed to be a direct port. So I guess I will add this extension method.
        public static void consumeBG(this FF12RNGHelper.IRNG rng, ulong amount, BackgroundWorker worker, DoWorkEventArgs e)
        {
            System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
            timer.Start();
            for (ulong i = 0; i < amount; i++)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    rng.genrand();
                    if (timer.ElapsedMilliseconds > 300)
                    {
                        timer.Restart();
                        worker.ReportProgress((int)((float)i / (float)amount * 100));
                    }
                }
            }
            worker.ReportProgress(100);
        }

    }
}
