//Manuel A Nunes
using System;
using NSDataModule;

namespace LocationObjUtils
{
    public class LocationObj
    {
        public string LocationID, Description, IsOutdoors, HasBarAccess, HasKitchenAccess, HasLakeAccess, HasSwimmingPool, HasMusicSetup, HasStage;
        public LocationObj() { }
        public LocationObj(string locationID, string description, string isOutdoors, string hasBarAccess, string hasKitchenAccess, string hasLakeAccess, string hasSwimmingPool, string hasMusicSetup, string hasStage)
        {
            LocationID = locationID;
            Description = description;
            IsOutdoors = isOutdoors;
            HasBarAccess = hasBarAccess;
            HasKitchenAccess = hasKitchenAccess;
            HasLakeAccess = hasLakeAccess;
            HasSwimmingPool = hasSwimmingPool;
            HasMusicSetup = hasMusicSetup;
            HasStage = hasStage;
        }
        public bool isFilled()
        {
            return !String.IsNullOrEmpty(LocationID) && !String.IsNullOrEmpty(Description);
        }
        public bool UpdateSelf()
        {
            try
            {
                return DataModule.ExecuteSQL($"UPDATE tblLocation SET Description = '{this.Description}', IsOutdoors = {this.IsOutdoors}," +
                    $"HasBarAccess = {this.HasBarAccess},HasKitchenAccess = {this.HasKitchenAccess},HasLakeAccess = {this.HasLakeAccess}," +
                    $"HasSwimmingPool = {this.HasSwimmingPool},HasMusicSetup = {this.HasMusicSetup},HasStage = {this.HasMusicSetup} WHERE LocationID = {this.LocationID} ")>0;
            }
            catch (Exception E)
            {
                return false;
                throw new Exception(E.ToString());
            }
        }
        public bool InsertSelf()
        {
            try
            {
                return DataModule.ExecuteSQL($"INSERT INTO tblLocation (Description,IsOutdoors,HasBarAccess,HasKitchenAccess,HasLakeAccess,HasSwimmingPool,HasMusicSetup,HasStage) VALUES " +
                    $"('{this.Description}',{this.IsOutdoors},{this.HasBarAccess},{this.HasKitchenAccess},{this.HasLakeAccess},{this.HasSwimmingPool},{this.HasMusicSetup},{this.HasStage})")> 0; 
            }
            catch (Exception E )
            {
                return false;
                throw new Exception(E.ToString());
            }
        }
        public bool LoadFromDB(string ID)
        {
            try
            {
                string[] Row = DataModule.GetValues($"SELECT LocationID,Description,IsOutdoors,HasBarAccess,HasKitchenAccess,HasLakeAccess,HasSwimmingPool,HasMusicSetup,HasStage FROM tblLocation WHERE LocationID = {ID}",new int[] {0,1,2,3,4,5,6,7,8 })[0];
                this.LocationID = Row[0];
                this.Description = Row[1];
                this.IsOutdoors = Row[2];
                this.HasBarAccess = Row[3];
                this.HasKitchenAccess = Row[4];
                this.HasLakeAccess = Row[5];
                this.HasSwimmingPool = Row[6];
                this.HasMusicSetup = Row[7];
                this.HasStage = Row[8];
                return isFilled();
            }
            catch (Exception E)
            {
                return false;   
                throw new Exception(E.ToString());
            }
        }
        public bool DeleteSelf()
        {
            try
            {
                return DataModule.ExecuteSQL($"DELETE FROM `tblLocation` WHERE LocationID={this.LocationID}")>0;
            }
            catch (Exception E)
            {
                return false;
                throw E;
            }
        }
    }
}
