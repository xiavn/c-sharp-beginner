using System.Collections.Generic;
namespace DelegatesSolution
{   
    public delegate float ShippingFeesDelegate(float itemPrice);
    class ShippingInfo {

        float _defaultHighRiskCost = 25f;
        (float rate, bool isHighRisk)[] _zones = {(25f, false), (12f, true), (8f, false), (4f, true)};

        public Dictionary<string, ShippingDestination> ShippingZones = new Dictionary<string, ShippingDestination>();

        public ShippingInfo() {
            for (int i = 0; i < _zones.Length; i++) {
                ShippingDestination zone = new ShippingDestination(_zones[i].rate, _zones[i].isHighRisk ? _defaultHighRiskCost : 0);
                string name = $"zone{i+1}";
                ShippingZones.Add(name, zone);
            }
        }

        public ShippingDestination? getShippingDestination(string destination) {
            return ShippingZones.GetValueOrDefault(destination);
        }
    }

    class ShippingDestination {

        float _extraCharge; float _shippingPercent;
        public ShippingDestination(float baseShippingChargePercentage, float extraCharge = 0) {
            _extraCharge = extraCharge;
            _shippingPercent = baseShippingChargePercentage;
        }

        public float getShippingCosts(float itemPrice) {
            float shippingPrice = (_shippingPercent/100)*itemPrice + _extraCharge;
            return shippingPrice;
        }
    }
}