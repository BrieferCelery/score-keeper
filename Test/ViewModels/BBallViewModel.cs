using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Input;
using Test.ViewModels.Base;
using Xamarin.Forms;
using Xamarin.Essentials;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Pages;

namespace Test.ViewModels
{
    public class BBallViewModel : BaseViewModel
    {
# region variables
        int _homeScore;
        int _awayScore;

        bool _buttonEnabled;

        #endregion
        public BBallViewModel()
        {
            PlayerALongRangeShotCommand = new Command(PlayerALongRangeShotScored);
            PlayerACloseRangeShotCommand = new Command(PlayerACloseRangeShotScored);

            PlayerBLongRangeShotCommand = new Command(PlayerBLongRangeShotScored);
            PlayerBCloseRangeShotCommand = new Command(PlayerBCloseRangeShotScored);

            PlayerAMinusCommand = new Command(PlayerAMinusOne);
            PlayerBMinusCommand = new Command(PlayerBMinusOne);
            ResetCommand = new Command(Reset);
        }

        
        #region Commands

        public ICommand PlayerACloseRangeShotCommand { get; set; }
        public ICommand PlayerALongRangeShotCommand { get; set; }

        public ICommand PlayerBCloseRangeShotCommand { get; set; }
        public ICommand PlayerBLongRangeShotCommand { get; set; }

        public ICommand PlayerAMinusCommand { get; set; }
        public ICommand PlayerBMinusCommand { get; set; }
        public ICommand ResetCommand { get; set; }
       
        #endregion

        private void PlayerALongRangeShotScored()
        {
            var result = _homeScore += 3;
            if (_homeScore >= 21)
            {

            }
            HomeScore = result.ToString();
            Vibration.Vibrate(100);
        }


        private void PlayerACloseRangeShotScored()
        {
            var result = _homeScore += 2;
            if (_homeScore >= 21)
            {
            }
            HomeScore = result.ToString();
            Vibration.Vibrate(50);
        }


        private void PlayerBLongRangeShotScored()
        {
            var result = _awayScore += 3;
            if (_awayScore >= 21)
            {
            }
            AwayScore = result.ToString();
            Vibration.Vibrate(100);
        }

        private void PlayerBCloseRangeShotScored()
        {
            var result = _awayScore += 2;
            if(_awayScore >=21)
            {
            }
            AwayScore = result.ToString();
            Vibration.Vibrate(50);
        }



        private void PlayerAMinusOne()
        {
            if (_homeScore -1 < 0)
            {
                _homeScore = 0;
            }
            
            else
            {
                var result = _homeScore -= 1;
                HomeScore = result.ToString();
            }
         }

        private void PlayerBMinusOne()
        {
            if (_awayScore - 1 < 0)
            {
                _awayScore = 0;
            }

            else
            {
                var result = _awayScore -= 1;
                AwayScore = result.ToString();
            }
        }


        public string HomeScore
        {
            get { return _homeScore.ToString(); }
            set
            {
                _homeScore.ToString();
                RaisePropertyChanged();
            }
        }

       
        public string AwayScore
        {
            get { return _awayScore.ToString(); }
            set
            {
                _awayScore.ToString();
                RaisePropertyChanged();
            }
        }

        public bool ButtonEnabled
        {
            get { return _buttonEnabled; }
            set 
            { 
                _buttonEnabled = value;
                RaisePropertyChanged();
            }
        }
        public void Reset()
        {
            _homeScore = 0;
            HomeScore = _homeScore.ToString();

            _awayScore = 0;
            AwayScore = _awayScore.ToString();
        }

    }
}
