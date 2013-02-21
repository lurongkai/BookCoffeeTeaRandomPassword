using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Web;
using System.Windows.Forms;

namespace BookCoffeeTeaRandomPassword
{
    public partial class MainWindow : Form
    {
        private string password = "";
        private SynchronizationContext sc = null;
        public MainWindow() {
            InitializeComponent();
            sc = SynchronizationContext.Current;

            GeneratePassword();
            DisplayRandomPasswordAndDateTime();
        }

        private void DisplayRandomPasswordAndDateTime() {
            lblNowDate.Text += DateTime.Now.ToShortDateString();
            tbxPassword.Text = password;
        }

        private void GeneratePassword() {
            var day = DateTime.Now.Date;
            var passwordSeed = day.ToString();

            var hashPassword = GetSHA1(passwordSeed);

            password = hashPassword.Substring(0, 8);
        }

        private string GetSHA1(string text) {
            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] hashValue;
            byte[] message = UE.GetBytes(text);

            SHA1Managed hashString = new SHA1Managed();
            string hex = "";

            hashValue = hashString.ComputeHash(message);
            foreach (byte x in hashValue) {
                hex += String.Format("{0:x2}", x);
            }
            return hex;
        }

        private const string AuthToken = "YWRtaW46YWRtaW4=";
        private const string ModifyPasswordHead = "";
        private void ModifyRouterWirelessPassword() {
            var changePasswordAddress = String.Format("http://192.168.1.1/userRpm/WlanSecurityRpm.htm?vapIdx=1&secType=3&pskSecOpt=3&pskCipher=3&pskSecret={0}&interval=86400&wpaSecOpt=3&wpaCipher=1&radiusIp=&radiusPort=1812&radiusSecret=&intervalWpa=86400&wepSecOpt=3&keytype=1&keynum=1&key1=&length1=0&key2=&length2=0&key3=&length3=0&key4=&length4=0&Save=%B1%A3+%B4%E6 ", password);
            var changePasswordRequest = HttpWebRequest.Create(changePasswordAddress);
            AppendAuthHeader(changePasswordRequest.Headers);
            changePasswordRequest.GetResponse();

            var rebootAddress = "http://192.168.1.1/userRpm/SysRebootRpm.htm?Reboot=%D6%D8%C6%F4%C2%B7%D3%C9%C6%F7 ";
            var rebootRequest = HttpWebRequest.Create(rebootAddress);
            AppendAuthHeader(rebootRequest.Headers);
            rebootRequest.GetResponse();
        }

        private void AppendAuthHeader(WebHeaderCollection headerCollection) {
            headerCollection.Add("Authorization", "Basic " + AuthToken);
        }

        private void btnModifyRouter_Click(object sender, EventArgs e) {
            Action action = ModifyRouterWirelessPassword;
            btnModifyRouter.Enabled = false;
            action.BeginInvoke(ar => {
                sc.Post(spc => {
                    ShowSuccess();
                    btnModifyRouter.Enabled = true;
                }, null);
            }, null);
        }

        private void ShowSuccess() {
            MessageBox.Show("Modify Success!");
        }
    }
}
