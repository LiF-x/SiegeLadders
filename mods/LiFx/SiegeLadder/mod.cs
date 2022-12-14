/**
* <author>Warped ibun</author>
* <email>lifxmod@gmail.com</email>
* <url>lifxmod.com</url>
* <credits>Christophe Roblin <christophe@roblin.no> modification to make it yolauncher server modpack and lifxcompatible</credits>
* <description>knools from mmo introduced to Lif:YO</description>
* <license>GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007</license>
*/

if (!isObject(LiFxSiegeLadder))
{
    new ScriptObject(LiFxSiegeLadder)
    {
    };
}

package LiFxSiegeLadder

{
    function LiFxSiegeLadder::setup() {
        LiFx::registerCallback($LiFx::hooks::onServerCreatedCallbacks, Datablock, LiFxSiegeLadder); //Datablock setup
        LiFx::registerCallback($LiFx::hooks::onInitServerDBChangesCallbacks, ConChanges, LiFxSiegeLadder); //Conversion setup
        LiFx::registerCallback($LiFx::hooks::onServerCreatedCallbacks, Dbchanges, LiFxSiegeLadder); // Recipies Setup
        LiFx::registerCallback($LiFx::hooks::onInitServerDBChangesCallbacks, changePlayerData, LiFxSiegeLadder);
        LiFx::registerObjectsTypes(LiFxSiegeLadder::ObjectsTypesSmallSiegeLadder(), LiFxSiegeLadder);
        LiFx::registerObjectsTypes(LiFxSiegeLadder::ObjectsTypesSiegeLadder(), LiFxSiegeLadder); 
        LiFx::registerObjectsTypes(LiFxSiegeLadder::ObjectsTypesLargeSiegeLadder(), LiFxSiegeLadder);
        LiFx::registerObjectsTypes(LiFxSiegeLadder::ObjectsTypesBigSiegeLadder(), LiFxSiegeLadder); 
        LiFx::registerObjectsTypes(LiFxSiegeLadder::ObjectsTypesSmallSiegeLadderB(), LiFxSiegeLadder); //all below allow for object to be picked up
        LiFx::registerObjectsTypes(LiFxSiegeLadder::ObjectsTypesSiegeLadderB(), LiFxSiegeLadder);  
        LiFx::registerObjectsTypes(LiFxSiegeLadder::ObjectsTypesLargeSiegeLadderB(), LiFxSiegeLadder);
        LiFx::registerObjectsTypes(LiFxSiegeLadder::ObjectsTypesBigSiegeLadderB(), LiFxSiegeLadder); 

    }
    function LiFxSiegeLadder::version() {
        return "0.0.2";
    }

        function LiFxSiegeLadder::ObjectsTypesSmallSiegeLadder() {
        return new ScriptObject(ObjectsTypesSmallSiegeLadder : ObjectsTypes)
        {
            id = 2489; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Small Siege Ladder";
            ParentID = 75;
            IsContainer = 0;
            IsMovableObject = 1;
            IsUnmovableobject = 0;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 0;
            Length = 6; 
            MaxStackSize = 0;
            UnitWeight = 200000;
            BackgrndImage = "art\\\\images\\\\universal";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "";
            Description = "";
            BasePrice = 0;
            OwnerTimeout = 300;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }
  
            function LiFxSiegeLadder::ObjectsTypesSiegeLadder() {
        return new ScriptObject(ObjectsTypesSiegeLadder : ObjectsTypes)
        {
            id = 2490; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Siege Ladder";
            ParentID = 75;
            IsContainer = 0;
            IsMovableObject = 1;
            IsUnmovableobject = 0;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 0;
            Length = 6; 
            MaxStackSize = 0;
            UnitWeight = 200000;
            BackgrndImage = "art\\\\images\\\\universal";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "";
            Description = "";
            BasePrice = 0;
            OwnerTimeout = 300;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }
    
            function LiFxSiegeLadder::ObjectsTypesLargeSiegeLadder() {
        return new ScriptObject(ObjectsTypesLargeSiegeLadder : ObjectsTypes)
        {
            id = 2491; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Large Siege Ladder";
            ParentID = 75;
            IsContainer = 0;
            IsMovableObject = 1;
            IsUnmovableobject = 0;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 0;
            Length = 6; 
            MaxStackSize = 0;
            UnitWeight = 200000;
            BackgrndImage = "art\\\\images\\\\universal";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "";
            Description = "";
            BasePrice = 0;
            OwnerTimeout = 300;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }
            function LiFxSiegeLadder::ObjectsTypesBigSiegeLadder() {
        return new ScriptObject(ObjectsTypesBigSiegeLadder : ObjectsTypes)
        {
            id = 2492; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Big Siege Ladder";
            ParentID = 75;
            IsContainer = 0;
            IsMovableObject = 1;
            IsUnmovableobject = 0;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 0;
            Length = 6; 
            MaxStackSize = 0;
            UnitWeight = 200000;
            BackgrndImage = "art\\\\images\\\\universal";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "";
            Description = "";
            BasePrice = 0;
            OwnerTimeout = 300;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }
    
            function LiFxSiegeLadder::ObjectsTypesSmallSiegeLadderB() {
        return new ScriptObject(ObjectsTypesSmallSiegeLadderB : ObjectsTypes)
        {
            id = 3023; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Small Siege Ladder";
            ParentID = 1902;
            IsContainer = 0;
            IsMovableObject = 1;
            IsUnmovableobject = 0;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 0;
            Length = 6; 
            MaxStackSize = 1;
            UnitWeight = 1000;
            BackgrndImage = "art\\\\images\\\\universal";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "";
            Description = "";
            BasePrice = 0;
            OwnerTimeout = 300;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }
            function LiFxSiegeLadder::ObjectsTypesSiegeLadderB() {
        return new ScriptObject(ObjectsTypesSiegeLadderB : ObjectsTypes)
        {
            id = 3024; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Siege Ladder";
            ParentID = 1902;
            IsContainer = 0;
            IsMovableObject = 1;
            IsUnmovableobject = 0;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 0;
            Length = 6; 
            MaxStackSize = 1;
            UnitWeight = 1000;
            BackgrndImage = "art\\\\images\\\\universal";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "";
            Description = "";
            BasePrice = 0;
            OwnerTimeout = 300;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }
    
            function LiFxSiegeLadder::ObjectsTypesLargeSiegeLadderB() {
        return new ScriptObject(ObjectsTypesLargeSiegeLadderB : ObjectsTypes)
        {
            id = 3025; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Large Siege Ladder";
            ParentID = 1902;
            IsContainer = 0;
            IsMovableObject = 1;
            IsUnmovableobject = 0;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 0;
            Length = 6; 
            MaxStackSize = 1;
            UnitWeight = 1000;
            BackgrndImage = "art\\\\images\\\\universal";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "";
            Description = "";
            BasePrice = 0;
            OwnerTimeout = 300;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }
            function LiFxSiegeLadder::ObjectsTypesBigSiegeLadderB() {
        return new ScriptObject(ObjectsTypesBigSiegeLadderB : ObjectsTypes)
        {
            id = 3026; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Big Siege Ladder";
            ParentID = 1902;
            IsContainer = 0;
            IsMovableObject = 1;
            IsUnmovableobject = 0;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 0;
            Length = 6; 
            MaxStackSize = 1;
            UnitWeight = 1000;
            BackgrndImage = "art\\\\images\\\\universal";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "";
            Description = "";
            BasePrice = 0;
            OwnerTimeout = 300;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }
       
    
  function LiFxSiegeLadder::conChanges() {
      dbi.Update("INSERT IGNORE `objects_conversions` VALUES (NULL, 2489, 3023)");
      dbi.Update("INSERT IGNORE `objects_conversions` VALUES (NULL, 2490, 3024)");
      dbi.Update("INSERT IGNORE `objects_conversions` VALUES (NULL, 2491, 3025)");
      dbi.Update("INSERT IGNORE `objects_conversions` VALUES (NULL, 2492, 3026)");
      }
        function LiFxSiegeLadder::Dbchanges() {
      //CRAFTABLE ITEMS
           ///////////////////////////////////////Recipe /////////////////////////////////////////////
      dbi.Update("INSERT IGNORE `recipe` VALUES (1106, 'Small Siege Ladder', 'This is a good way to stop little boy pew pew', 44, 10, 0, 2489, 10, 10, 0, 0, 'yolauncher/modpack/mods/LiFx/SiegeLadder/art/Models/2d/recipie/SmallSiegeLadder.png')");
      dbi.Update("INSERT IGNORE `recipe` VALUES (1107, 'Large Siege Ladder', 'This is a good way to stop little boy pew pew', 44, 10, 30, 2491, 10, 10, 0, 0, 'yolauncher/modpack/mods/LiFx/SiegeLadder/art/Models/2d/recipie/LargeSiegeLadder.png')");
      dbi.Update("INSERT IGNORE `recipe` VALUES (1108, 'Siege Ladder', 'This is a good way to stop little boy pew pew', 44, 10, 0, 2490, 10, 10, 0, 0, 'yolauncher/modpack/mods/LiFx/SiegeLadder/art/Models/2d/recipie/SmallSiegeLadder.png')");
      dbi.Update("INSERT IGNORE `recipe` VALUES (1109, 'Big Siege Ladder', 'This is a good way to stop little boy pew pew', 44, 10, 30, 2492, 10, 10, 0, 0, 'yolauncher/modpack/mods/LiFx/SiegeLadder/art/Models/2d/recipie/LargeSiegeLadder.png')");

     ///////////////////////////////////////Recipe Requirements /////////////////////////////////////////////

    //Small siege Ladder
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, 1106, 235, 0, 15, 10, 0)");
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, 1106, 233, 0, 15, 2, 0)");
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, 1106, 32, 0, 15, 20, 0)");
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, 1106, 1356, 0, 10, 20, 0)");

     
    //Siege Ladder
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, 1108, 235, 0, 15, 10, 0)");
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, 1108, 233, 0, 15, 2, 0)");
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, 1108, 32, 0, 15, 20, 0)");
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, 1108, 1356, 0, 10, 20, 0)");

    //Large Siege Ladder
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, 1107, 1356, 0, 55, 12, 0)");
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, 1107, 235, 0, 15, 2, 0)");
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, 1107, 233, 0, 10, 4, 0)"); 
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, 1107, 32, 0, 15, 20, 0)"); 

    //Big Siege Ladder
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, 1109, 1356, 0, 55, 12, 0)");
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, 1109, 235, 0, 15, 2, 0)");
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, 1109, 233, 0, 10, 4, 0)"); 
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, 1109, 32, 0, 15, 20, 0)");  

    }

    function LiFxSiegeLadder::changePlayerData() {
    PlayerData.runSurfaceAngle = 75;
    exec("./player.cs");
  }
};
activatePackage(LiFxSiegeLadder);