using Estimationtool.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estimationtool.Models
{






    public class Product: BaseViewModel
    {

        private string id;
        public string Id
        {
            get { return this.id; }
            set { this.SetProperty(ref this.id, value); }
        }


        private string wbselement;
        public string WBSElement
        {
            get { return this.wbselement; }
            set { this.SetProperty(ref this.wbselement, value); }
        }


        private string productNo;
        public string ProductNo
        {
            get { return this.productNo; }
            set { this.SetProperty(ref this.productNo, value); }
        }



        private string itemDescription;
        public string ItemDescription
        {
            get { return this.itemDescription; }
            set { this.SetProperty(ref this.itemDescription, value); }
        }


        private string matrialNo;
        public string MatrialNo
        {
            get { return this.matrialNo; }
            set { this.SetProperty(ref this.matrialNo, value); }
        }


        private string size;
        public string Size
        {
            get { return this.size; }
            set { this.SetProperty(ref this.size, value); }
        }


        private string specification;
        public string Specification
        {
            get { return this.specification; }
            set { this.SetProperty(ref this.specification, value); }
        }


        private string description;
        public string Description
        {
            get { return this.description; }
            set { this.SetProperty(ref this.description, value); }
        }


        private string project;
        public string Project
        {
            get { return this.project; }
            set { this.SetProperty(ref this.project, value); }
        }


        private string qtyReq;
        public string QtyReq
        {
            get { return this.qtyReq; }
            set { this.SetProperty(ref this.qtyReq, value); }
        }


        private string unitofMeasurment;
        public string UnitofMeasurment
        {
            get { return this.unitofMeasurment; }
            set { this.SetProperty(ref this.unitofMeasurment, value); }
        }


        private string unitWt;
        public string UnitWt
        {
            get { return this.unitWt; }
            set { this.SetProperty(ref this.unitWt, value); }
        }


        private string weightUnit;
        public string WeightUnit
        {
            get { return this.weightUnit; }
            set { this.SetProperty(ref this.weightUnit, value); }
        }


        private string purchasingDocument;
        public string PurchasingDocument
        {
            get { return this.purchasingDocument; }
            set { this.SetProperty(ref this.purchasingDocument, value); }
        }


        private string item;
        public string Item
        {
            get { return this.item; }
            set { this.SetProperty(ref this.item, value); }
        }


        private string purchaseOrderNo;
        public string PurchaseOrderNo
        {
            get { return this.purchaseOrderNo; }
            set { this.SetProperty(ref this.purchaseOrderNo, value); }
        }




        private string unitRatePrice;
        public string UnitRatePrice
        {
            get { return this.unitRatePrice; }
            set { this.SetProperty(ref this.unitRatePrice, value); }
        }




        private string netOrderPrice;
        public string NetOrderPrice
        {
            get { return this.netOrderPrice; }
            set { this.SetProperty(ref this.netOrderPrice, value); }
        }


        private string currency;
        public string Currency
        {
            get { return this.currency; }
            set { this.SetProperty(ref this.currency, value); }
        }


        private string supplierName;
        public string SupplierName
        {
            get { return this.supplierName; }
            set { this.SetProperty(ref this.supplierName, value); }
        }


        private string destination;
        public string Destination
        {
            get { return this.destination; }
            set { this.SetProperty(ref this.destination, value); }
        }
                                    


    }
}
