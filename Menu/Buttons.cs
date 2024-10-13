using StupidTemplate.Classes;
using StupidTemplate.Mods;
using Zloths_Simple_Menu.Mods;
using static StupidTemplate.Settings;

namespace StupidTemplate.Menu
{
        


    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods [1]
                new ButtonInfo { buttonText = "Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Opens the main settings page for the menu."},


                new ButtonInfo
                {
                    buttonText = "Movement Mods",
                    method = delegate()
                    {
                        SettingsMods.MoveMods();
                    },
                    isTogglable = false,
                    toolTip = "Opens the Movement Mods page for the menu!"
                },


                new ButtonInfo { buttonText = "Disconnect", method =() => dc.Disconnect(), toolTip = "Pretty obvious but disconnects you from the current room your in.", isTogglable = false},
                new ButtonInfo { buttonText = "Join Discord", method =() => JoinDiscord.JoinMyDC(), toolTip = "Joins my Discord server", isTogglable = false},
                new ButtonInfo { buttonText = "Anti Report (Dc)", method =() => AntiReportDC.AntiReportDisconnectMod(), enabled = true, toolTip = "You get disconnected if someone tries to report you. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Anti Report (JR)", method =() => antireportrandom.AntiReportDisconnectMod(), toolTip = "You get connected to a random public if someone tries to report you. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Ghost Monke", method =() => Ghost_Monke.Ghostmonkeymod(), toolTip = "Hold A. Makes your body freeze, perfect for English or Spanish. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Invis Monke", method =() => Invis.InvisMonke(), toolTip = "Hold B. Your body goes bye bye. *gets mogged* UND", isTogglable = true},
                new ButtonInfo { buttonText = "Fly", method =() => NormFly.Fly(), toolTip = "Fly in the direction of your head, enable with A. UND", isTogglable = true},
                new ButtonInfo { buttonText = "WASD Fly", method =() => wasd_fly.WASDFly(), toolTip = "Fly using WASD keys on your computer. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Up and Down Fly", method =() => FlyMod.Fly(), toolTip = "Right Trigger to fly up, and left trigger to go down. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Trigger Fly", method =() => trigfly.trigflymod(), toolTip = "Fly in the direction of your head, enable with right trigger. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Left Grip Fly", method =() => lHandFly.LeftHandFly(), toolTip = "Hold left grip to fly and move left hand to controll direction. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Car Monkey", method =() => CarMonk.Carmonkey(), toolTip = "Nice whip! UND", isTogglable = true},
                new ButtonInfo { buttonText = "Low Gravity", method =() => gravity.LowGravity(), toolTip = "Gives you moon like gravity. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Zero Gravity", method =() => gravity.ZeroGravity(), toolTip = "I guess you really did become an astronaut...UND", isTogglable = true},
                new ButtonInfo { buttonText = "Speed Boost", method =() => SpeedBoost.SpeedBoostMod(), toolTip = "Grants you a slight speedboost. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Platforms", method =() => Platforms.PlatformsMod(), toolTip = "Walk on a magic floor!. UND", isTogglable = true},
                //new ButtonInfo { buttonText = "Sticky Platforms", method =() => StickPlats.PlatformsMod(), toolTip = "Walk on a magic sticky floor!. UND", isTogglable = true},


                new ButtonInfo { buttonText = "NoClip", method =() => NoClips.NoClip(), toolTip = "Is the floor there or not, I cant tell?. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Remove ToS & ModIO", method =() => no_more_tos.RemoveTOSandModIO(), toolTip = "Removes ToS and ModIO board agreement. UND", isTogglable = false},
                new ButtonInfo { buttonText = "Disbale Quit Box", method =() => ByeQuit.DisableQuitBox(), toolTip = "No more death if you fall out of the map. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Physical Quit Box (NW)", method =() => ByeQuit.DisableQuitBox(), toolTip = "Turns the QUIT box into a STAND box. UND", isTogglable = false},
                new ButtonInfo { buttonText = "Punch Mod", method =() => PunchMod.BetterPunchMod(), toolTip = "You can be punched by other players. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Tag All (D?)", method =() => tagall.ActivateTagAll(), toolTip = "Tags every player that is currently untagged. D?", isTogglable = true},
                new ButtonInfo { buttonText = "Ghost Tag All (D?)", method =() => ghosttagall.ActivateGhostTagAll(), toolTip = "Tags every player that is currently unghosted. D?", isTogglable = true},
                new ButtonInfo { buttonText = "Tag Aura", method =() => tag_aura.ActivateTagAura(), toolTip = "Tags nearby players. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Ghost Tag Aura", method =() => ghost_tag_aura.ActivateGhostTagAura(), toolTip = "Tags nearby players in Ghost Tag. UND", isTogglable = true},
                new ButtonInfo { buttonText = "*Goofy* Tag Gun?", method =() => taggun.TagGun(), toolTip = "Tags players with a gun. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Flick Tag Gun", method =() => flicktag.flicktagmod(), toolTip = "Tags nearby players but with a gun. UND", isTogglable = true},
                new ButtonInfo { buttonText = "AM i the master?", method =() => amimaster.CheckIFMaster(), toolTip = "Checks weather or not your master client. UND", isTogglable = false}, 
                new ButtonInfo { buttonText = "Join Zloth Code", method =() => JoinZlothCode.JoinCodeZlothMod(), toolTip = "Joins my code. UND", isTogglable = false},
                new ButtonInfo { buttonText = "Day Time", method =() => DayTime.DayTimeMod(), toolTip = "Day Time. UND", isTogglable = false},
                new ButtonInfo { buttonText = "Night Time", method =() => NightTime.EveningTime(), toolTip = "Night Time. UND", isTogglable = false},
                new ButtonInfo { buttonText = "TP Gun", method =() => TeleportGun.Tpgun(), toolTip = "You become the bullet. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Wall Walk", method =() => Wall_Walk.WallWalk(), toolTip = "Left grip to drift left, right grip to drift right. UND", isTogglable = true},
                new ButtonInfo { buttonText = "TP to Stump", method =() => TpStump.TPTOSTUMP(), toolTip = "Teleports you instantly to stump. UND", isTogglable = false},
                new ButtonInfo { buttonText = "TP to Tutorial", method =() => tptutorial.TPTOTUTORIAL(), toolTip = "Teleports you instantly to tutorial. UND", isTogglable = false},
                new ButtonInfo { buttonText = "Join Random", method =() => Lobby_Hop.LobbyHopMod(), toolTip = "Disconnects you from current room and join a new one. UND", isTogglable = false},
                new ButtonInfo { buttonText = "No Name (NW?)", method =() => noname.NoNamemod(), toolTip = "Who are you? UND", isTogglable = false},
                new ButtonInfo { buttonText = "Zloth Name (NW?)", method =() => ZlothUserName.ZlothName(), toolTip = "Makes your name 'ZlothUser' TYSM for using this menu btw!!!  UND", isTogglable = false},
                new ButtonInfo { buttonText = "Unlock Comp Queue", method =() => comp.UnlockCompetitiveQueue(), toolTip = "Unlocks competative queue. UND", isTogglable = false},
                new ButtonInfo { buttonText = "No slip on forest walls", method =() => no_slip.NoSlip(), toolTip = "Make all slippery objects...not slippery. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Chams", method =() => chams.CasualChams(), toolTip = "Makes the players rig visible through all objects. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Glow Chams", method =() => chams.GlowChams(), toolTip = "Makes the players rig visible through all objects but is a nice glowing colour. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Infection Chams", method =() => chams.InfectionChams(), toolTip = "Makes the players on the other team visible through all objects. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Infection Glow Chams", method =() => chams.InfectionGlowChams(), toolTip = "Makes the players on the other team visible through all objects but is a nice glowing colour. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Ghost Tag Chams", method =() => chams.GhostChamsMod(), toolTip = "Makes the players on the other team in ghost tag visible through all objects. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Ghost Tag Glow Chams", method =() => chams.GhostChams(), toolTip = "Makes the players on the other team in ghost visible through all objects but is a nice glowing colour. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Tracers", method =() => tracers.Tracers(), toolTip = "Makes tracers to all players. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Infection Tracers", method =() => InfectionTracers.Tracers(), toolTip = "Makes tracers to the opposite team. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Ghost Tag Tracers", method =() => GhostTracers.GhostTracersMod(), toolTip = "Makes tracers to teh opposite ghost team. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Show ghosts", method =() => GhostVisibility.Postfix(), toolTip = "Shows all ghost objects including Skeleton Players during ghost tag. UND", isTogglable = false},
                new ButtonInfo { buttonText = "Box ESP", method =() => boxesp.ESPboxMod(), toolTip = "See players through the walls. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Fix Players Colours", method =() => fixrigcolour.FixRigColors(), toolTip = "Some mods break players colours on your screen so this fixed that. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Rare Cosmetic Beacon", method =() => rare_cosmetic_esp.CosmeticESP(), toolTip = "Puts a beacon on a player if they have a rare cosmetic like fingerpainter. UND", isTogglable = true},
                new ButtonInfo { buttonText = "CURRENT MATERIAL (Owner only)", method =() => MaterialLogger.LogMaterial(), toolTip = "No tool tip, debug mod", isTogglable = false},
                new ButtonInfo { buttonText = "CURRENT DATA (Owner only)", method =() => GameDataLogger.LogGameData(), toolTip = "No tool tip, debug mod", isTogglable = false},
                new ButtonInfo { buttonText = "PLAYER ID", method =() => SavePlayerID.SaveID(), toolTip = "No tool tip, debug mod", isTogglable = false},
                new ButtonInfo { buttonText = "Spawn Red Lucy (M)", method =() => lucy_mods.SpawnRedLucy(), toolTip = "Spawns the red lucy", isTogglable = false},
                new ButtonInfo { buttonText = "Spawn Blue Lucy (M)", method =() => lucy_mods.SpawnBlueLucy(), toolTip = "Spawns the blue lucy", isTogglable = false},
                new ButtonInfo { buttonText = "Lucy Chase Self (M)", method =() => lucy_mods.LucyChaseSelf(), toolTip = "Makes lucy chase you", isTogglable = true},
                new ButtonInfo { buttonText = "Lucy Attack Self (M)", method =() => lucy_mods.LucyAttackSelf(), toolTip = "Makes lucy attack you", isTogglable = true},
                new ButtonInfo { buttonText = "Slow Lucy (M)", method =() => lucy_mods.SlowLucy(), toolTip = "Makes lucy slow", isTogglable = true},
                new ButtonInfo { buttonText = "Fast Lucy (M)", method =() => lucy_mods.FastLucy(), toolTip = "Makes lucy fast", isTogglable = true},
                new ButtonInfo { buttonText = "Spaz Lucy (M)", method =() => lucy_mods.SpazLucy(), toolTip = "Makes lucy spaz out", isTogglable = true},
                new ButtonInfo { buttonText = "Despawn Lucy (M)", method =() => lucy_mods.DespawnLucy(), toolTip = "Kills Lucy", isTogglable = false},
                new ButtonInfo { buttonText = "Magenta Ghost", method =() => ghost_colours.MagentaGhost(), toolTip = "Makes ghost Magenta", isTogglable = false},
                new ButtonInfo { buttonText = "Red Ghost", method =() => ghost_colours.RedGhost(), toolTip = "Makes ghost Red", isTogglable = false},
                new ButtonInfo { buttonText = "Black Ghost", method =() => ghost_colours.BlackGhost(), toolTip = "Makes ghost black", isTogglable = false},
                new ButtonInfo { buttonText = "Green Ghost", method =() => ghost_colours.GreenGhost(), toolTip = "Makes ghost Green", isTogglable = false},
                new ButtonInfo { buttonText = "Blue Ghost", method =() => ghost_colours.BlueGhost(), toolTip = "Makes ghost blue", isTogglable = false},
                new ButtonInfo { buttonText = "Gray Ghost", method =() => ghost_colours.GrayGhost(), toolTip = "Makes ghost gray", isTogglable = false},
                new ButtonInfo { buttonText = "Yellow Ghost", method =() => ghost_colours.YellowGhost(), toolTip = "Makes ghost yellow", isTogglable = false},
                new ButtonInfo { buttonText = "Pumpkin Gun (Invisible)", method =() => PumpingGun.Gun(), toolTip = "Pumpkin Gun", isTogglable = true},
                new ButtonInfo { buttonText = "Fake Oculus Menu", method =() => fake_oc.FakeOcMod(), toolTip = "Makes your hand go in your body when you hold A like an Oculus menu does. UND", isTogglable = true},
                new ButtonInfo { buttonText = "PaintBot (D?)", method =() => paintbot.PaintBotMod(), toolTip = "Gives you aimbot in Paintbrawl when holding a slingshot. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Fake Shutdown Headset (Needs more testing)", method =() => fakeheadsetoff.FakeOff(), toolTip = "Press A to enable/disable. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Oculus Report Menu (Cant exit report menu)", method =() => oculus_report.OculusReportMenu(), toolTip = "A to open report menu. UND", isTogglable = true},

            },

            new ButtonInfo[] { // Settings [2]
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Menu", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
                new ButtonInfo { buttonText = "Custom MOTD (NW)", method =() => customboards.customboardsON(), disableMethod =() => customboards.customboardsOFF(), isTogglable = true, enabled = true, toolTip = "Toggles the custom boards."},
                new ButtonInfo { buttonText = "Admin User Check", method =() => adminenbled.admincheck(), isTogglable = false, enabled = true, toolTip = "Checks if you are an admin whe you start the game."},
                new ButtonInfo { buttonText = "Game Version Check", method =() => new VersionChecker().CheckForUpdates(), isTogglable = false, enabled = true, toolTip = "Checks if you are an admin whe you start the game."},
              //  new ButtonInfo { buttonText = "Ui", method =() => showui.ShowMyUI(), isTogglable = false, enabled = true, toolTip = "Checks if you are an admin whe you start the game."},

            },

            

            new ButtonInfo[] { // Menu Settings [3]
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Right Hand", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand."},
                new ButtonInfo { buttonText = "Notifications", enableMethod =() => SettingsMods.EnableNotifications(), disableMethod =() => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications."},
                new ButtonInfo { buttonText = "FPS Counter", enableMethod =() => SettingsMods.EnableFPSCounter(), disableMethod =() => SettingsMods.DisableFPSCounter(), enabled = fpsCounter, toolTip = "Toggles the FPS counter."},
                new ButtonInfo { buttonText = "Disconnect Button", enableMethod =() => SettingsMods.EnableDisconnectButton(), disableMethod =() => SettingsMods.DisableDisconnectButton(), enabled = disconnectButton, toolTip = "Toggles the disconnect button."},
            },

            new ButtonInfo[] {//Movement Mods [4]
                new ButtonInfo
                {
                    buttonText = "Return to Main",
                    method = delegate()
                    {
                        Global.ReturnHome();
                    },
                    isTogglable = false,
                    toolTip = "Returns to the main page of the menu."
                },
                new ButtonInfo { buttonText = "Platforms", method =() => MoveMods.PlatformsMod(), toolTip = "Walk on a magic floor!. UND", isTogglable = true},
            }
        };
    }
}
