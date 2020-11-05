using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrivenDevelopment.Klassen
{
    public class Coffee
    {
        enum temperatureEnum { HOT, QUITEHOT, NOTSOHOT, COLD };

        temperatureEnum temperature;


        private string _temperatuer;

        
        public string Temperature
        {
            get {
                UpdateTemperature();
                return this._temperatuer; }
            set { this._temperatuer = value; }
        }


        public Coffee()
        {
            this._temperatuer = "";
        }
      

        private void UpdateTemperature()
        {

            switch (this.temperature)
            {
                case temperatureEnum.HOT:
                    this.temperature = temperatureEnum.QUITEHOT;
                    this._temperatuer = "Quite hot";
                    break;
                case temperatureEnum.QUITEHOT:
                    this.temperature = temperatureEnum.NOTSOHOT;
                    this._temperatuer = "Not so hot";
                    break;
                case temperatureEnum.NOTSOHOT:
                    this.temperature = temperatureEnum.COLD;
                    this._temperatuer = "Cold";
                    break;
                case temperatureEnum.COLD:
                    break;
                default:
                    this.temperature = temperatureEnum.HOT;
                    this._temperatuer = "Hot";
                    break;
            }
            
        }
        

    }
}
