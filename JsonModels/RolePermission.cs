using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtlasConnect.JsonModels
{
    public class RolePermission : BaseJson
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public bool InventoryStockRequisitionEnabled { get; set; }
        public bool InventoryStockGoodsReceiptEnabled { get; set; }
        public bool InventoryStockTakeEnabled { get; set; }
        public bool InventoryStockEnquiryEnabled { get; set; }
        public bool InventoryStockExpiryEnabled { get; set; }
        public bool InventoryStockReturnEnabled { get; set; }
        public bool InventoryStockTransferEnabled { get; set; }
        public bool InventoryStockIssueEnabled { get; set; }
        public bool InventoryStockSiteDeliveryEnabled { get; set; }
        public bool InventoryStockLocationDeliveryEnabled { get; set; }
        public bool InventoryStockUnplannedReceiptEnabled { get; set; }
        public bool InventoryStockQuarantineEnabled { get; set; }
        public bool PointOfCareBedsideEnabled { get; set; }
        public bool PointOfCareSurgeryEnabled { get; set; }
        public bool PointOfCarePreferenceCardsEnabled { get; set; }
        public bool TissueTrackingStockDockReceiptEnabled { get; set; }
        public bool TissueTrackingStockReceiptInspectionEnabled { get; set; }
        public bool TissueTrackingTransferEnabled { get; set; }
        public bool TissueTrackingTemperatureTrackingEnabled { get; set; }
        public bool TissueTrackingGoodsReturnEnabled { get; set; }
        public bool AssetManagementViewAssetEnabled { get; set; }
        public bool AssetManagementTransferEnabled { get; set; }

        public BsonDocument ToDocument() 
        {
            var rolePermissionDocument = new RolePermissionDocument
            {
                Description = Description,
                InventoryStockRequisitionEnabled = InventoryStockRequisitionEnabled,
                InventoryStockGoodsReceiptEnabled = InventoryStockGoodsReceiptEnabled,
                InventoryStockTakeEnabled = InventoryStockTakeEnabled,
                InventoryStockEnquiryEnabled = InventoryStockEnquiryEnabled,
                InventoryStockExpiryEnabled = InventoryStockExpiryEnabled,
                InventoryStockReturnEnabled = InventoryStockReturnEnabled,
                InventoryStockTransferEnabled = InventoryStockTransferEnabled,
                InventoryStockIssueEnabled = InventoryStockIssueEnabled,
                InventoryStockSiteDeliveryEnabled = InventoryStockSiteDeliveryEnabled,
                InventoryStockLocationDeliveryEnabled = InventoryStockLocationDeliveryEnabled,
                InventoryStockUnplannedReceiptEnabled = InventoryStockUnplannedReceiptEnabled,
                InventoryStockQuarantineEnabled = InventoryStockQuarantineEnabled,
                PointOfCareBedsideEnabled = PointOfCareBedsideEnabled,
                PointOfCareSurgeryEnabled = PointOfCareSurgeryEnabled,
                PointOfCarePreferenceCardsEnabled = PointOfCarePreferenceCardsEnabled,
                TissueTrackingStockDockReceiptEnabled = TissueTrackingStockDockReceiptEnabled,
                TissueTrackingStockReceiptInspectionEnabled = TissueTrackingStockReceiptInspectionEnabled,
                TissueTrackingTransferEnabled  = TissueTrackingTransferEnabled,
                TissueTrackingTemperatureTrackingEnabled = TissueTrackingTemperatureTrackingEnabled,
                TissueTrackingGoodsReturnEnabled = TissueTrackingGoodsReturnEnabled,
                AssetManagementViewAssetEnabled = AssetManagementViewAssetEnabled,
                AssetManagementTransferEnabled = AssetManagementTransferEnabled
            };
            rolePermissionDocument.SetCreateLastUpdate(this.CreatedOn, this.LastUpdatedOn, this.Id);

            return rolePermissionDocument.ToBsonDocument();
        }
    }

    public class RolePermissionDocument : BaseDocument 
    {
        public string Description { get; set; }
        public bool InventoryStockRequisitionEnabled { get; set; }
        public bool InventoryStockGoodsReceiptEnabled { get; set; }
        public bool InventoryStockTakeEnabled { get; set; }
        public bool InventoryStockEnquiryEnabled { get; set; }
        public bool InventoryStockExpiryEnabled { get; set; }
        public bool InventoryStockReturnEnabled { get; set; }
        public bool InventoryStockTransferEnabled { get; set; }
        public bool InventoryStockIssueEnabled { get; set; }
        public bool InventoryStockSiteDeliveryEnabled { get; set; }
        public bool InventoryStockLocationDeliveryEnabled { get; set; }
        public bool InventoryStockUnplannedReceiptEnabled { get; set; }
        public bool InventoryStockQuarantineEnabled { get; set; }
        public bool PointOfCareBedsideEnabled { get; set; }
        public bool PointOfCareSurgeryEnabled { get; set; }
        public bool PointOfCarePreferenceCardsEnabled { get; set; }
        public bool TissueTrackingStockDockReceiptEnabled { get; set; }
        public bool TissueTrackingStockReceiptInspectionEnabled { get; set; }
        public bool TissueTrackingTransferEnabled { get; set; }
        public bool TissueTrackingTemperatureTrackingEnabled { get; set; }
        public bool TissueTrackingGoodsReturnEnabled { get; set; }
        public bool AssetManagementViewAssetEnabled { get; set; }
        public bool AssetManagementTransferEnabled { get; set; }
    }
}
