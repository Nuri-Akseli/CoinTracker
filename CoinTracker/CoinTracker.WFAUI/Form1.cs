using CoinTracker.Business.Abstract;
using CoinTracker.Business.DependancyResolvers.Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinTracker.WFAUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _coinService = InstanceFactory.GetInstance<ICoinService>();
        }
        private ICoinService _coinService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCoins();
            SetTimer();
        }
        private void LoadCoins()
        {
            dgwCoin.DataSource = _coinService.GetList();
        }

        private void tbCoinSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbCoinSearch.Text.Trim() != null)
            {
                dgwCoin.DataSource = _coinService.GetList(tbCoinSearch.Text);
            }
        }
        private void SetTimer()
        {
            Timer timer = new Timer();
            timer.Interval = 10 * 1000;
            timer.Tick += new EventHandler(CoinTimer_Tick);
            timer.Start();
        }
        private void CoinTimer_Tick(object sender, EventArgs e)
        {
            LoadCoins();
        }
    }
}
