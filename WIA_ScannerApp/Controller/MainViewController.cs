using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIA_ScannerApp.Controller
{
    public class MainViewController
    {
        #region Properties
        private string testText;
        public string TestText { get => testText; set => testText = value; }
        #endregion

        #region Constructor
        public MainViewController()
        {
            TestText = "Binding success";
        }        
        #endregion

        #region Public Methods

        #endregion

        #region Private Methods

        #endregion
    }
}
