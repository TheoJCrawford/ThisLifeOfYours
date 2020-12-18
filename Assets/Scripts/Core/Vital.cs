using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLY.Core
{
    public struct Vital
    {
        private string _vitalName;
        private int _maxVital;
        private double _curVital;

        public string VitalName => _vitalName;
        public int maxVital => _maxVital;
        public int curVital => Convert.ToInt32(_curVital);

        public new string ToString()
        {
            return curVital.ToString() + " / " + maxVital.ToString();
        }
        public Vital(string vitName = "Health", int Max = 100)
        {
            _vitalName = vitName;
            _maxVital = Max;
            _curVital = _maxVital;
        }

        public void ModifyCurVital(double Input)
        {
            if (_curVital + Input > _maxVital)
            {
                _curVital = _maxVital;
            }
            else if(_curVital + Input <= 0)
            {
                _curVital = 0;
            }
            else
            {
                _curVital += Input;
            }
        }
        public void ModifyMaxVital(int Input)
        {
            if(_maxVital + Input > 20)
            {
                _maxVital += Input;
            }
            else
            {
                return;
            }
        }
        
    }
}
