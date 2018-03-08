using MetroFramework.Forms;
using System;
using Microsoft.Practices.Unity;
using BLL;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Threading.Tasks;

namespace UI
{
    public partial class 
        DigitalSignageScreen : Form , IObserver<string>, IObserver<byte[]>
    {

        //resuelve la dependencia para el servicio de campañas
        private IBannerService iBannerService = IoCContainerLocator.Container.Resolve<IBannerService>();

        //resuelve la dependencia para el servicio de campañas
        private ICampaignService iCampaignService = IoCContainerLocator.Container.Resolve<ICampaignService>();

        //variable para desubscribirse del banner service
        private Unsubscriber<string> iBannerUnsubscriber;

        //variable para desubscribirse del campaign service
        private Unsubscriber<byte[]> iCampaignUnsubscriber;

        //variable de texto con espacio para que el texto de banner entre por la izquierda
        private string WHITE_SPACE = new String(' ', 250);

        public DigitalSignageScreen()
        {
            InitializeComponent();

            iCampaignUnsubscriber = (Unsubscriber<byte[]>)iCampaignService.Subscribe(this);
            iBannerUnsubscriber = (Unsubscriber<string>)iBannerService.Subscribe(this);

            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            //inicio del timmer para mover el banner de texto
            timer1.Interval = 100;
            timer1.Start();
        }


        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(byte[] bytes)
        {
            var currenImage = byteArrayToImage(bytes);
            campaignImage.Image = currenImage;
        }

        public void OnNext(string text)
        {
            bannerText.Text = WHITE_SPACE + text;
        }

        private void DigitalSignageScreen_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {

                //minimizar pantalla
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.Sizable;

            }
            if (e.KeyCode == Keys.F11)
            {

                //minimizar pantalla
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;

            }

        }

        public byte[] imageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Task.Delay(TimeSpan.FromSeconds(0.5));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                /* Not on UI thread, reenter there... */
                this.BeginInvoke(new EventHandler(timer1_Tick), sender, e);
            }
            else
            {
                lock (timer1)
                {
                    /* only work when this is no reentry while we are already working */
                    if (this.timer1.Enabled)
                    {
                        this.timer1.Stop();

                        //mover el texto del banner
                        moveBannerText();

                        this.timer1.Start(); /* optionally restart for periodic work */
                    }
                }
            }
        }

        private void moveBannerText()
        {
           
            var currentText = bannerText.Text;
            if (string.IsNullOrEmpty(currentText))
            {
                return;
            }
            bannerText.Text = currentText.Substring(1) + currentText[0];

        }

    }
}
