using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopDataSync
{
    /**
     * This service uses the following REST API client for accessing the Magento REST API:
     * https://github.com/nickvane/Magento-RestApi
     */
    public partial class SuperShopDataSyncService : ServiceBase
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SuperShopDataSyncService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            log.Info("Starting SuperShop data sync service.");
        }

        protected override void OnStop()
        {
            log.Info("Stopping SuperShop data sync service.");
        }
    }
}
