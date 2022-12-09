/**
* <author>Warped ibun</author>
* <email>lifxmod@gmail.com</email>
* <url>lifxmod.com</url>
* <credits>Christophe Roblin <christophe@roblin.no> modification to make it yolauncher server modpack and lifxcompatible</credits>
* <description>Bear Knools from mmo introduced to Lif:YO</description>
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
    LiFx::registerCallback($LiFx::hooks::onMaterialsLoad, RegisterMaterials, LiFxSiegeLadder);
    LiFx::registerCallback($LiFx::hooks::onDatablockLoad, PlayerDatablock, LiFxSiegeLadder);
  }
/*
  function LiFxSiegeLadder::RegisterPlayerDatablock() {
      LiFx::loadRecursivelyInFolder("yolauncher/modpack/mods/LiFx/SiegeLadder/art/datablocks", "player.cs");
  }
*/
  function LiFxSiegeLadder::RegisterMaterials() {
    LiFx::loadRecursivelyInFolder("yolauncher/modpack/mods/LiFx/SiegeLadder", "Laddermaterials.cs");
  }

  function LiFxSiegeLadder::path() {
    return $Con::File;
  }
};
activatePackage(LiFxSiegeLadder);
LiFx::registerCallback($LiFx::hooks::mods, setup, LiFxSiegeLadder);