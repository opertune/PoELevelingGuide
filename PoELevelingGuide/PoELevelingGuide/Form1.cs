using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;


namespace PoELevelingGuide
{
    public partial class formQuete : Form
    {
        public formQuete()
        {
            InitializeComponent();
        }
        // Tableau des quetes
        object[][] act =
        {
            new string[]
            {
            "Kill Hillock at the end of the Twilight Strand.",
            "Enter Lioneye’s Watch and talk to Tarkleigh to receive the reward.",
            "Enter the Coast and run to the end of the zone. Ensure you acquire the Waypoint. Enter the Mud Flats.",
            "Find the 3 Rhoa Nests. Once you have the Ammonite Glyph, Haliotis Glyph, and Roseus Glyph, find the glyph wall and open the exit to The Submerged Passage. Enter and grab the Waypoint.",
            "(Optional): Take the Waypoint back to the Coast and enter the Tidal Island to the right. This is recommended for league starters due to the Quicksilver Flask it provides, as well as the gems it unlocks as rewards and for purchase.",
            "Run straight to Hailrake and kill him.",
            "Logout and turn the quest in with Nessa. Ensure you choose the Quicksilver Flask.",
            "Talk to Tarkleigh for the gem reward.",
            "Take the Waypoint to the Submerged Passage.",
            "Find the exit to the Ledge.",
            "Grab the Waypoint and continue on to the exit to the Climb.",
            "Run all the way through the Climb, grabbing the Waypoint if you come across it.",
            "Enter the Lower Prison and grab the Waypoint.",
            "Take the Waypoint to the Submerged Passage. If you were quick enough, your original instance should be open.",
            "Find the entrance to the Flooded Depths. Generally this is towards the bottom part of the map.",
            "Kill the Deep Dweller, then logout.",
            "Talk to Tarkleigh for the Book of Skill, then take the Waypoint to the Lower Prison.",
            "(Optional): Find the Labyrinth Trial and complete it.",
            "Locate the exit to the Upper Prison.",
            "Find the exit to the Warden’s Quarter’s, and immediately make your way to the Warden’s Chambers.",
            "Kill Brutus. Exit to Prisoner’s Gate and take the Waypoint back to Lioneye’s Watch.",
            "Talk to Tarkleigh to receive the gem reward.",
            "Take the Waypoint back to Prisoner’s Gate.",
            "Exit into the Ship Graveyard.",
            "Grab the Waypoint, always located near the entrance of the zone.",
            "Locate the Ship Graveyard Cave and enter it.",
            "Retrieve the Allflame and exit back into the Ship Graveyard.",
            "Find the exit into the Cavern of Wrath and acquire the Waypoint.",
            "Take the Waypoint back to the Ship Graveyard.",
            "Talk to Fairgraves and kill him. He is always located very near to the Waypoint.",
            "Either logout, or take the Waypoint back to Lioneye’s Watch. Talk to Bestel to receive the Book of Skill.",
            "Speak to Nessa for the gem reward.",
            "Take the Waypoint to the Cavern of Wrath.",
            "Exit into the Cavern of Anger.",
            "Exit into Merveil’s Lair.",
            "Kill Merveil and enter the Southern Forest.",
            "Run through the zone and enter the Forest Encampment."
            },
            new string[]
            {
            "Enter the Riverways, taking the left exit.",
            "Locate the Waypoint. It is typically found in the upper left part of the area, along the path.",
            "Find the exit into the Wetlands. It is always found near the Waypoint.",
            "Locate Oak, and kill him.",
            "Find the Waypoint, which is often found along the wall in the upper left part of the area.",
            "Take the Waypoint to the Riverways.",
            "Follow left along the edge of the zone from the Wetlands entrance to find the exit into the Western Forest.",
            "Run down the path in the middle of the area until you encounter the Waypoint.",
            "Follow either the left or right wall downwards : "+ "\r\n" + "\r\n" + " - If you find spiderwebbed trees, find the exit into the Weaver’s Chambers. Make your way to the end, enter the Weaver’s Nest, and kill The Weaver and take Maligaro’s Spike. Logout or portal back to town and talk to Silk to receive the gem reward. Take the Waypoint back to the Western Forest. Head in the opposite direction of where you found the Weaver’s Chambers to find Alira."+ "\r\n" + "\r\n" + " - If you find Alira and are planning on killing her, do that now. Logout or portal back to town, then take the Waypoint back to the Western Forest. Head in the opposite direction of where you found Alira to locate the Weaver’s Chambers.",
            "Follow the wall to the “bottom” part of the Western Forest, until you find the Blackguards.",
            "Kill the Blackguards and pick up the Thaumetic Seal. Open the exit to Act I.",
            "Logout or portal to town, then take the Waypoint to Act I. Talk to Bestel to receive the Book of Skill as a reward.",
            "Take the Waypoint to the Forest Encampment.",
            "Take the right exit this time, into the Old Fields.",
            "Follow the road until you find the exit into the Crossroads.",
            "Follow the path until you find the Waypoint.",
            "(Optional): Take the path leading downwards to find the exit to the Felshrine Ruins. Head downwards through the area until you find The Crypt (Level One). Find and complete the Labyrinth Trial within the area, then logout or portal back to town. Take the Waypoint back to the Crossroads.",
            "Take the right path to find the exit to the Broken Bridge.",
            "Follow the right wall until you encounter Kraityn.",
            "Kill or help Kraityn, depending on what your build recommends. If you are helping Alira, return to town and take the Waypoint to the Western Forest to do that now.",
            "Logout or portal to town. Speak with Eramir and take The Apex if you killed all of the bandits.",
            "Take the Waypoint to the Crossroads.",
            "Follow the upwards path until you find the entrance to the Chamber of Sins (Level One).",
            "Acquire the Waypoint if you come across it, and exit into the Chamber of Sins (Level Two).",
            "(Optional): Find the Labyrinth Trial in this area, and complete it.",
            "Locate Fidelitas and kill him. He is typically found in the upper left part of the area.",
            "Take the Baleful Gem and speak with Helena. Logout or portal back to town.",
            "Speak with Greust to acquire the gem reward.",
            "Take the Waypoint to the Wetlands and poison the tree roots next to the waypoint.",
            "Enter the Vaal Ruins and break the seal when you encounter it.",
            "Exit into the Northern Forest.",
            "Head upwards through the Northern Forest until you find the exit into the Caverns. Do not enter the Dread Thicket.",
            "Grab the Waypoint when you encounter it.",
            "Locate the entrance to the Ancient Pyramid.",
            "Ascend the levels of the pyramid until you find the Pyramid Apex.",
            "Slay the Vaal Oversoul and exit into the City of Sarn.",
            "Find the Blackguards and kill them to rescue Clarissa. Make sure that you speak with Clarissa before running off.",
            "Enter the Sarn Encampment. This is always found in the upper left part of the area."
            },
            new string[]
            {
                "Exit into the Slums.",
            "Find the Crematorium and grab the Waypoint. Take note of the location of the Sewer Grating, if you encountered it along the way.",
            "(Optional): Find the Labyrinth Trial in the Crematorium and complete it.",
            "Find Piety and defeat her. Interact with Tolman and take Tolman’s Bracelet.",
            "Logout or portal back to town. Speak with Clarissa to receive the Sewer Keys.",
            "Enter the Slums and find the Sewer Grating. Open it, and enter the Sewers.",
            "Locate the three Platinum Busts. There is always one before the Waypoint, and two after it.",
            "Find the exit into the Marketplace.",
            "Grab the Waypoint.",
            "(Optional): Just to the upper right of the Waypoint is the entrance to the Catacombs. Enter and complete the Labyrinth Trial, then logout or portal out and return to the Marketplace via the waypoint.",
            "Locate the exit to the Battlefront.",
            "Find the Waypoint, which is generally in the center of the zone.",
            "Head downwards from the Waypoint until you find the Blackguard Chest, which looks like a cart.",
            "Take the Ribbon Spool from the cart.",
            "Head upwards from the Waypoint until you locate the entrance to the Solaris Temple (Level One).",
            "Proceed through the temple until you find the entrance to the Solaris Temple (Level Two).",
            "Continue through the temple until you find the Waypoint.",
            "Take the Waypoint to the Battlefront. Head left until you find the entrance to the Docks.",
            "Locate the Supply Container and take the Thaumetic Sulphite.",
            "Logout or portal to town, then talk to Hargan to receive the Book of Skill.",
            "Take the Waypoint to the Solaris Temple (Level Two).",
            "Talk to Lady Dialla to receive the Infernal Talc.",
            "Take the Waypoint to the Sewers.",
            "Go down/left from the Waypoint and burn away the Undying Blockage. This is always extremely close to the waypoint.",
            "Enter the Ebony Barracks and acquire the Waypoint.",
            "Head upwards through the Ebony Barracks until you find General Gravicius.",
            "Kill General Gravicius, and continue heading upwards.",
            "Enter the Lunaris Temple (Level One).",
            "Grab the Waypoint and enter the Lunaris Temple (Level Two).",
            "Look for ascending staircases to quickly find the correct path. Continue following the staircases until you reach the carts. The side with two carts is always a dead end, while the single-cart side is the correct path.",

            "Kill Piety and take the Tower Key.",
            "Return to town and talk to Grigor to receive the Book of Skill. Speak with Maramoa to receive the gem reward.",
            "Take the Waypoint to the Ebony Barracks.",
            "Head to the right of the Waypoint until you find the entrance to the Imperial Gardens.",
            "Follow the tiled path until you find the Waypoint.",

            "(Optional): If you need specific gems from the Library quest, take the upper left path at the three way fork, up the stairs. Enter the Library and grab the Waypoint halfway through the area. Continue until you find the Loose Candle :"+ "\r\n" + " - Click on it and enter The Archives. Collect the Four Golden Pages before returning to town via portal or logout. Take the Waypoint back to the Library and speak to Siosa for your reward. Take the Waypoint back to the Imperial Gardens.",
            "(Optional): Complete the final Labyrinth Trial for the Normal Lab. From three way fork just above the Waypoint, head upwards and slowly snake your way to the left. The Labyrinth Trial is almost always found in the uppermost left corner of the area.",
            "From the three way fork above the way point, head to the lower right and up the stairs. Start heading to the upper right, following the tiled path until you find the entrance to the Sceptre of God.",
            "Enter the Sceptre of God and ascend the levels until you find the Upper Sceptre of God.",
            "Enter the Upper Sceptre of God and ascend the levels.",
            "Kill Dominus.",
            "Enter the Aqueduct and make your way through the area.",
            "Enter Highgate."
            },
            new string[]
            {
            "Enter The Dried Lake.",
            "Locate Voll, defeat him, and take Deshret’s Banner. Return to town via logout or Portal",
            "Open the mines using Deshret’s Banner and enter The Mines(Level One).",
            "Proceed through the area and enter The Mines(Level Two).",
            "Locate Deshret’s Spirit and release it.",
            "Enter the Crystal Veins.",
            "Locate the Waypoint, at the end of the area, and return to Highgate.",
            "Speak to Tasuni to receive the Book of Skill reward. Speak to Oyun to receive the Golem gem reward.",
            "Return to the Crystal Veins via the Waypoint.",
            "The next steps may be completed in either order, based on preference.We prefer to do Kaom’s Dream first, however, as the boss is generally a little less dangerous at lower levels :"+ "\r\n" + " - Enter Kaom’s Dream and proceed through the area until you reach Kaom’s Stronghold. Acquire the Waypoint and continue onwards, until you reach the Caldera of the King. Defeat Kaom and pick up the Eye of Fury.Return to town via logout or Portal, then take the Waypoint to the Crystal Veins."+ "\r\n" + " - Enter Daresso’s Dream and proceed through the area until you encounter Barkhul.Defeat him and his bodyguards, then enter The Grand Arena and acquire the Waypoint.Proceed through the arenas until you encounter “The Trio”, a group of three unique enemies. This means that Daresso is in the next area, and signals you are on the correct path. Defeat the Trio and enter The Ring of Blades.Defeat Daresso and take the Eye of Desire. Return to town via logout or Portal, then take the Waypoint to the Crystal Veins.",

            "Talk to Dialla.",
            "Enter the Belly of the Beast (Level One), and proceed through the area.",
            "Enter the Belly of the Beast (Level Two), and proceed through the area.",
            "Enter the Bowels of the Beast.",
            "Defeat Piety.",
            "Enter The Harvest, and acquire the Waypoint. Return to Highgate.",
            "Speak to Dialla at the uppermost part of the city to receive the gem reward.",
            "Return to The Harvest.",
            "Slay Malachai’s 3 guardians; Doedre, Maligaro, and Shavronne.Pick up the various organs they drop.",
            "Enter The Black Core, found next to the Waypoint.",
            "Kill Malachai.",
            "Return to Highgate via Portal or logout.",
            "Exit into The Ascent, found in the upper right part of Highgate.",
            "Interact with the resonator and take the Oriath Portal."
            },
            new string[]
            {
                "Grab the Waypoint and make your way through the Slave Pens.",
            "Kill Overseer Crow, and ascend the ladder that drops down to enter the Overseer’s Tower.",
            "Talk to Lani to receive the ring reward.",
            "Enter the Control Blocks.",
            "Find the Miasmeter. Typically this item is found about halfway through the zone, on the left-most part of the area.",
            "Kill Justicar Casticus at the end of the area and pick up the Eyes of Zeal.",
            "Enter Oriath Square and grab the Waypoint.",
            "Find and enter the Templar Courts.",
            "Make your way through the zone and enter The Chamber of Innocence, grabbing the immediate Waypoint.",
            "Find The Sanctum of Innocence and kill High Templar Avarius and Innocence.",
            "Enter The Chamber of Innocence through the newly opened exit.",
            "Enter the Torched Courts and make your way through the area.",
            "Enter the Ruined Square. The entrances to other areas in the Ruined Square are always in the same general area of the zone. We have provided an extremely simplified diagram below to help you quickly locate what you are looking for.",

            "Enter the Ossuary.",
            "Find the Sign of Purity and return to the Ruined Square via the exit.",
            "Locate The Reliquary.",
            "Find each of Kitava’s Torments and return to town via logout or Portal.",
            "Speak to Lani for the Book of Skill and jewel rewards.",
            "Return to the Ruined Square via Waypoint.",
            "Enter the Cathedral Rooftop and make your way through the area.",
            "Enter the Cathedral Apex and defeat Kitava.",
            "Speak with Lily Roth and sail to Wraeclast."
            },
            new string[]
            {
            "(Optional): This quest is usually worth doing on new league characters as it unlocks Lilly Roth as a gem vendor, and she carries virtually every gem in the game. Enter the Twilight Strand, accessed from the bottom side of Lioneye’s Watch. Clear the area of all monsters and return to Lioneye’s Watch, then speak with Lilly Roth.",
            "Enter The Coast and proceed through the zone. Grab the Waypoint at the end.",
            "Enter the Mud Flats. Find and kill The Dishonored Queen and take the Eye of Conquest.",
            "Find the exit to the Karui Fortress. Generally, this is in the upper middle part of the area.",
            "Enter Tukohama’s Keep.",
            "Defeat Tukohama. Talk to Sin and select Soul of Tukohama as your Pantheon Minor God.",
            "Find and enter The Ridge.",
            "Grab the Waypoint and return to Lioneye’s Watch. Talk to Tarkleigh to receive the Book of Skill.",
            "Return to The Ridge via the Waypoint.",
            "Find and enter the Lower Prison and grab the Waypoint, just inside the entrance.",
            "(Optional): Find the Labyrinth trial and complete it.",
            "Find and enter Shavronne’s Tower.",
            "Ascend the tower until you reach the Prison Rooftop.",
            "Kill Brutus and Shavronne.",
            "Go through the Warden’s Chambers and enter the Prisoner’s Gate. Grab the Waypoint.",
            "(Optional): Find the Valley of the Fire Drinker and defeat Abberath. Portal to Lioneye’s Watch and talk to Bestel for the Book of Skill reward. Take the Waypoint back to the Prisoner’s Gate. Head in the other direction of where you found the Valley of the Fire Drinker (e.g. if Abberath is bottom right, head to top right and vice versa).",
            "Enter the Western Forest. Follow the main road to find the Waypoint.",
            "Find and enter The Riverways. Follow the main road to find the Waypoint.",
            "(Optional): Find and enter The Wetlands, usually located in the upper part of the area. Find the Spawning Ground and kill the Puppet Mistress. Portal or logout to return to Lioneye’s Watch and speak to Tarkleigh for the Book of Skill reward. Return to The Riverways via Waypoint.",
            "Find and enter the Southern Forest. The entrance is usually located in middle/lower right of the area.",
            "Grab the Waypoint before exiting into the Cavern of Anger.",
            "Open the Flag Chest and take the Black Flag.",
            "Enter the passage and make your way through the cavern until you reach The Beacon. Enter and immediately acquire the Waypoint.",
            "Locate the pyramid-esque structure and ascend it. Escort the two pillars to their berths by standing within the glowing circle.",
            "Click on the Ignition Switch and then again on the Beacon.",
            "Talk to Weylam Roth and sail to the Brine King’s Reef. Grab the Waypoint.",
            "Locate and enter the Brine King’s Throne. This is usually easiest done by following the left wall.",
            "Kill the Brine King. Speak to Sin and grab your Pantheon.",
            "Talk to Weylam Roth and sail to Act VII."
            },
            new string[]
            {
                "Enter the Broken Bridge. Travel towards the bottom left part of the area.",
            "Enter The Crossroads. Grab the Waypoint in the center of the zone.",
            "Take the bottom fork from the Waypoint and enter the Fellshrine Ruins.",
            "Enter The Crypt and acquire the Waypoint.",
            "(Optional): Find the Labyrinth trial and complete it.",
            "Find the Sarcophagus and descend to The Crypt (Level Two).",
            "Locate the Container of Sins and take Maligaro’s Map.",
            "Return to the Bridge Encampment via Portal or logout.",
            "Return to The Crossroads via Waypoint.",
            "Take the upper path from the Waypoint and enter the Chamber of Sins (Level 1).",
            "Grab the Waypoint at the central cross and insert Maligaro’s Map into the Map Device.",
            "Enter Maligaro’s Sanctum and proceed until you find Maligaro’s Workshop.",
            "Kill Maligaro and take the Black Venom. Leave the map via Portal Scroll Portal Scroll.",
            "Speak with Silk and take the Obsidian Key.",
            "Find and enter the _Chamber of Sins (Level Two).",
            "(Optional): Find the Labyrinth trial and complete it.",
            "Enter The Den.",
            "Proceed and exit into the Ashen Fields.",
            "Enter the Fortress Encampment.",
            "Slay Greust.",
            "Enter the Northern Forest.",
            "Grab the Waypoint.",
            "(Optional): Return to town and speak with Helena to receive Greust’s Necklace. This quest only rewards an amulet but usually does not take more than a minute or so in total time, so it is your choice on a league starter whether to complete it. If you encounter the Azmeri Shrine in the Northern Forest, place the necklace there and speak with Helena when you are next in town turning in other quests.",
            "Enter the Dread Thicket."+ "\r\n" + " - Enter the Den of Despair and kill Gruthkul, then return to the Dread Thicket."+ "\r\n" + " - Collect 7 Fireflies from around the Dread Thicket.",
            "Return to the Bridge Encampment and speak with Eramir to receive the two Books of Skill as a reward.",
            "Return to the Northern Forest via the Waypoint.",
            "Find the exit to The Causeway",
            "Grab the Waypoint when you encounter it.",
            "Acquire Kishara’s Star before leaving the area, usually find right next to the exit of the zone.",
            "Enter the Vaal City.",
            "Locate Yeena. The Vaal City is a massive, sprawling, and confusing zone for some players. There is always a part of the zone that is surrounded by dead ends, and is difficult to penetrate into (the “center” of the city, but not of the area itself). Yeena and the Waypoint are always found here.",
            "Speak with Yeena and enter the Temple of Decay (Level One).",
            "Enter the Temple of Decay (Level Two).",
            "Enter Arakaali’s Web.",
            "Kill Arakaali.",
            "Enter the Sarn Ramparts.",
            "Enter the Sarn Encampment."
            },
            new string[]
            {
                "Enter the Toxic Conduits.",
            "Locate and enter Doedre’s Cesspool.",
            "Open the grate and enter The Cauldron.",
            "Kill Doedre the Vile.",
            "Exit into the Sewer Outlet and grab the Waypoint.",
            "Take the right path and enter The Quay.",
            "Open the Sealed Casket and take the Ankh of Eternity. The Ankh is typically found near the entrance of the zone; look for a long bridge.",

            "Locate and enter the Ressurection Site and kill Tolman.",
            "Talk to Clarissa.",
            "Return to The Quay.",
            "Enter the Grain Gate and grab the Waypoint. Head “upwards” through the zone, roughly following the right-upper wall of the area.",
            "Kill the Gemling Legionnaires.",
            "Enter the Imperial Fields and follow the main road to find the Waypoint.",
            "Return to the Sarn Encampment.Speak to Clarissa and Maramoa for the Book of Skill rewards.Speak to Hargan for the ring reward.",
            "Return to the Imperial Fields.",
            "Enter the Solaris Temple (Level One).",
            "Acquire the Waypoint if you come across it.",
            "Enter the Solaris Temple (Level Two).",
            "Kill Dawn and take the Sun Orb.Return to town via logout or Portal.",
            "Return to the Toxic Conduits via Waypoint.",
            "Take the left path and enter the Grand Promenade.",
            "Enter the Bath House.",
            "Acquire the Waypoint.",
            "(Optional): These next steps are both optional, and can be done in either order if you choose to do both, based on what you encounter first :"+ "\r\n" + " - Find the Labyrinth trial and complete it.Portal out and return to the Bath House via Waypoint."+ "\r\n" + " - Enter the High Gardens and proceed until you encounter the Pools of Terror.Enter and slay Yugul. Portal out and speak to Hargan for the Book of Skill reward.Return to the Bath House via Waypoint.",
            "Enter the Lunaris Concourse.",
            "Acquire the Waypoint.",
            "Enter the Lunaris Temple (Level 1). The path to the Lunaris Temple is the same as in Act III, always heading upwards until you encounter it.",
            "Acquire the Waypoint, then enter the Lunaris Temple (Level 2).",
            "Kill Dusk and take the Moon Orb, then return to town via logout or Portal.",
            "Return to the Lunaris Concourse via Waypoint.",
            "Enter the Harbour Bridge, which is always below the Waypoint.",
            "Enter the Sky Shrine.",
            "Kill Solaris and Lunaris.",
            "Enter the Blood Aqueducts.",
            "Enter Highgate."
            },
            new string[]
            {
                "Enter The Descent and head to the right.",
            "Descend via the Supply Hoists until you locate the exit to the Vastiri Desert.",
            "Locate and acquire the Waypoint.",
            "(Optional): Locate the Storm Weathered Chest. Defeat the waves of mummies that ambush you, then take the Storm Blade. Return to town via Portal Scroll and speak with Petarus and Vanja. Talk to Sin, then speak again with Petarus and Vanja. Use your portal to return to the Vastiri Desert. Find the entrance to The Oasis, which will now be accessible using the Bottled Storm.Traverse the area and enter the Sand Pit.Kill Shakari and return to Highgate. Speak to Irasha for the Book of Skill reward.Return to the Vastiri Desert via Waypoint.",
            "Enter The Foothills.",
            "Find the Waypoint, usually located in the upper right part of the area.",
            "Enter the Boiling Lake.",
            "Kill the Basilisk and take the Basilisk Acid. You know you are in the area where the Basilisk is located once you begin to see groups of petrified enemies.",
            "Return to Highgate and take the Waypoint back to The Foothills.",
            "Enter The Tunnel, usually found in the upper or upper left part of the area.",
            "Acquire the Waypoint.",
            "(Optional): Find the Labyrinth trial and complete it.",
            "Enter The Quarry.Run straight to the middle of the zone and acquire the Waypoint.",
            "These steps can be completed in either order based on what you encounter first. Follow the right wall if you do not wish to do the optional quest for the Passive Skill point :"+ "\r\n" + " - Enter The Refinery and explore the area until you find General Adus, then kill him.He is found in his own little arena, generally in the upper or upper left part of the area.Usually he is found faster if you take the left path from the start of the area.Interact with the Theurgic Precipitate Machine and take the Trarthan Powder.Portal or logout, then return to The Quarry via Waypoint."+ "\r\n" + " - (Optional): Enter the Shrine of the Winds and slay Garukhan.Return to town via Portal or logout, then speak with Irasha to receive the Book of Skill reward.Return to The Quarry via Waypoint.",

            "Talk to Sin and enter the Belly of the Beast.",
            "Enter the Rotting Core and make your way through the area.",
            "Enter the Black Core and talk to Sin.",
            "Enter each of the portals in your order of choosing and defeat Malachai’s guardians (Shavronne, Maligaro, and Doedre).",
            "Enter the Black Heart and kill the Depraved Trinity.",
            "Talk to Lilly Roth and sail to Oriath."
            },
            new string[]
            {
            "Enter the Cathedral Rooftop.",
            "Enter the Cathedral Apex, on the immediate left of entering the rooftop area.",
            "Kill the Cultists and Gargoyles to free Bannon.",
            "Return to the Cathedral Rooftop and make your way to the right.",
            "Enter the Ravaged Square.",
            "Head upwards until you encounter the Waypoint, and acquire it.",
            "These steps are both optional, and are both found in the Ossuary next to the Waypoint."+ "\r\n" + " - Find the Labyrinth trial and complete it."+ "\r\n" + " - Find the Elixir of Allure (rewards Respec points).",
            "Enter the Torched Courts and proceed through the area.",
            "Enter the Desecrated Chambers, which has a similar layout to the Chambers of Innocence from Act V. Grab the immediate Waypoint.",
            "Find and kill Avarius, Reassembled.",
            "Return to the Oriath Docks using the Waypoint.",
            "Talk to Bannon, then talk to Lani to receive the Flask and Armor rewards.",
            "(Optional): Return to the Ravaged Square and head downwards to the bottom middle of the area.Enter the Control Blocks and find Vilenta, located roughly where the Miasmeter was in Act V.Kill Vilenta and return to town via logout or Portal. Talk to Lani to receive the Book of Skill reward.",
            "Talk to Innocence.",
            "Return to the Ravaged Square and head upwards until you find Innocence. Speak with him.",
            "Enter the Canals and proceed through the area.",
            "Enter The Feeding Trough and proceed through the area",
            "Speak with Sin and enter the Altar of Hunger.",
            "Kill Kitava.",
            "Speak with Lani in Oriath to receive the Book of Skill reward."
            },
        };
        // Tableau des images des act
        Image[] map =
        { 
            Properties.Resources.act1, 
            Properties.Resources.act2, 
            Properties.Resources.act3, 
            Properties.Resources.act4,
            Properties.Resources.act5, 
            Properties.Resources.act6, 
            Properties.Resources.act7, 
            Properties.Resources.act8, 
            Properties.Resources.act9, 
            Properties.Resources.act10 
        };
        // Déclaration
        public static string save = "Save";
        /*
         * Controle du design des bouttons
         */
        private void design()
        {
            // Couleur de fond pour la form et la zone de texte des quetes
            BackColor = Color.FromArgb(40, 40, 40);
            txtQuete.BackColor = Color.FromArgb(40, 40, 40);
            btnGem.BackColor = Color.FromArgb(40, 40, 40);
            btnQuete.BackColor = Color.FromArgb(40, 40, 40);
            btnBack.BackColor = Color.FromArgb(40, 40, 40);
            btnNext.BackColor = Color.FromArgb(40, 40, 40);
            cbbAct.BackColor = Color.FromArgb(40, 40, 40);
            btnChangerProfil.BackColor = Color.FromArgb(40, 40, 40);
            btnGem.FlatAppearance.MouseOverBackColor = Color.FromArgb(83, 83, 83);
            btnQuete.FlatAppearance.MouseOverBackColor = Color.FromArgb(83, 83, 83);
            btnNext.FlatAppearance.MouseOverBackColor = Color.FromArgb(83, 83, 83);
            btnBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(83, 83, 83);
            btnChangerProfil.FlatAppearance.MouseOverBackColor = Color.FromArgb(83, 83, 83);
            btnLoadImg.FlatAppearance.MouseOverBackColor = Color.FromArgb(83, 83, 83);
            btnLoadImg.BackColor = Color.FromArgb(40, 40, 40);
        }
        /*
         * Evenement chargement de la fenettre
         */
        private void Form1_Load(object sender, EventArgs e)
        {
            // Creation du dossier qui contient les images de l'arbre de talent si il n'existe pas
            if (!Directory.Exists(Application.StartupPath + "\\images"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\images");
            }
            // Initialise la list des acts
            for (int k = 1; k < 11; k++)
            {
                cbbAct.Items.Add("Act " + k);
            }
            design();
            chargementProfil();
            this.Text = formProfil.profiles[formProfil.index].getName();
        }
        /*
         * Procedure qui gère le chargement d'un profil
         */
         private void chargementProfil()
        {
            // Affiche la fenetre de selection de profil
            formProfil profile = new formProfil();
            profile.ShowDialog();
            // Récupération de l'act et du numéro de la quete de la précédente session
            Object deserialize = Save.Recup(save);
            // Affiche la page des quetes
            btnQuete_Click(null, null);
            // Sauvegarde du n° de l'act
            cbbAct.SelectedIndex = formProfil.profiles[formProfil.index].getAct();
            // Affichage de la quete
            affichageQuete();
            // Remplie les zones de text de la page Build
            txtGems.Text = formProfil.profiles[formProfil.index].getGems();
            // Charge l'image de l'arbre de talent si elle existe
            string imagePath = Application.StartupPath + "\\images\\" + formProfil.profiles[formProfil.index].getName() + ".jpg";
            if (File.Exists(imagePath))
            {
                // Crée le flux qui permet de récupérer l'image
                FileStream stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
                // Ajoute l'image à la picture box
                imgTalentTree.Image = Image.FromStream(stream);
                // Ferme le flux
                stream.Close();
            }
            else // Sinon la picturebox est reset
            {
                imgTalentTree.Image = null;
            }
        }
        /*
         * Procedure controle des boutons next/back
         * Active ou désactive les boutons next/back suivant la position de la quete
         */
        private void controleBouton()
        {
            if (formProfil.profiles[formProfil.index].getQuete() == 0)
            {
                btnBack.Enabled = false;
            }
            else
            {
                btnBack.Enabled = true;
            }
            if (formProfil.profiles[formProfil.index].getQuete() == act[formProfil.profiles[formProfil.index].getAct()].Length-1)
            {
                btnNext.Enabled = false;
            }
            else
            {
                btnNext.Enabled = true;
            }
        }
        /*
         * Procedure Pour afficher les quetes
         */
        private void affichageQuete()
        {
            controleBouton();
            txtQuete.Text = (formProfil.profiles[formProfil.index].getQuete() + 1) + ". " + act[cbbAct.SelectedIndex][formProfil.profiles[formProfil.index].getQuete()];
            img();
            formProfil.profiles[formProfil.index].setAct(cbbAct.SelectedIndex); // Sauvegarde le n° de l'act 
            formProfil.profiles[formProfil.index].setQuete(formProfil.profiles[formProfil.index].getQuete()); // Sauvegarde le n° de la quete

            // Serialize le numéro de la quete et de l'act
            Save.Sauve(save, formProfil.profiles);
        }

        /*
         * Procedure pour afficher une image
         */
        private void img()
        {
            // Image de la carte de chaque act
            imgQuete.Image = map[cbbAct.SelectedIndex];

            // Image spécifique
            if (cbbAct.Text == "Act 3" && formProfil.profiles[formProfil.index].getQuete() == 29)
            {
                imgQuete.Image = Properties.Resources.act3q30;
            }
            else if (cbbAct.Text == "Act 3" && formProfil.profiles[formProfil.index].getQuete() == 34)
            {
                imgQuete.Image = Properties.Resources.act3q35;
            } else if (cbbAct.Text == "Act 3" && formProfil.profiles[formProfil.index].getQuete() == 35)
            {
                imgQuete.Image = Properties.Resources.act3q36;
            } else if (cbbAct.Text == "Act 5" && formProfil.profiles[formProfil.index].getQuete() == 12)
            {
                imgQuete.Image = Properties.Resources.act5q13;
            } else if (cbbAct.Text == "Act 8" && formProfil.profiles[formProfil.index].getQuete() == 6)
            {
                imgQuete.Image = Properties.Resources.act8q7;
            }
        }
        
        /*
         * Evenement bouton next click
         * Avance d'une quête
         */
        private void btnNext_Click(object sender, EventArgs e)
        {
            int nb = formProfil.profiles[formProfil.index].getQuete();
            nb++;
            formProfil.profiles[formProfil.index].setQuete(nb);
            affichageQuete();
        }

        /*
         * Evenement bouton précédent click
         * Recule d'une quête
         */
        private void btnBack_Click(object sender, EventArgs e)
        {
            int nb = formProfil.profiles[formProfil.index].getQuete();
            nb--;
            formProfil.profiles[formProfil.index].setQuete(nb);
            affichageQuete();
        }
        
        // Passage à la fenetre avec les quetes
        private void btnQuete_Click(object sender, EventArgs e)
        {
            btnQuete.Enabled = false;
            btnGem.Enabled = true;
            btnBack.Visible = true;
            btnNext.Visible = true;
            cbbAct.Visible = true;
            txtQuete.Visible = true;
            imgQuete.Visible = true;
            lblGems.Visible = false;
            lblTalents.Visible = false;
            txtGems.Visible = false;
            btnLoadImg.Visible = false;
            lblLoadTree.Visible = false;
            panel1.Visible = false;
        }
        // Passage à la fenetre avec les gem
        private void btnGem_Click(object sender, EventArgs e)
        {
            btnGem.Enabled = false;
            btnQuete.Enabled = true;
            btnBack.Visible = false;
            btnNext.Visible = false;
            cbbAct.Visible = false;
            txtQuete.Visible = false;
            imgQuete.Visible = false;
            lblGems.Visible = true;
            lblTalents.Visible = true;
            txtGems.Visible = true;
            btnLoadImg.Visible = true;
            lblLoadTree.Visible = true;
            panel1.Visible = true;
            txtGems.ScrollBars = ScrollBars.Vertical;
        }
        /*
         * Change l'act sur demande de l'utilisateur
         * Et reset le numéro de la quete
         */
        private void cbbAct_SelectionChangeCommitted(object sender, EventArgs e)
        {
            formProfil.profiles[formProfil.index].setQuete(0);
            affichageQuete();
        }
        // Changement de profil de profil
        private void btnChangerProfil_Click(object sender, EventArgs e)
        {
            formQuete_FormClosed(null, null);
            imgTalentTree.Image = null;
            this.Hide();
            formQuete f = new formQuete();
            f.ShowDialog();
            this.Close();
        }

        // Sauvegarde la page Build à la fermeture
        private void formQuete_FormClosed(object sender, FormClosedEventArgs e)
        {
            formProfil.profiles[formProfil.index].setGems(txtGems.Text);
            // Serialize les zones de text de la page Build
            Save.Sauve(save, formProfil.profiles);
        }

        // Ouvre la fenetre pour choisir une image
        private void btnLoadImg_Click(object sender, EventArgs e)
        {
            // Crée la fenetre de dialogue
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // Filtre pour afficher que les images avec les extension jpg jpeg et png
            openFileDialog.Filter = "Image Files(*jpg; *.jpeg; *.bmp; *.png)|*jpg; *.jpeg; *.bmp; *.png";

            // Si le fichier séléctionné est conforme -> ajoute l'image à la picturebox et la copie dans la dossier de sauvegarde "Images"
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Ajout de l'image à la picturebox
                // Crée le flux qui permet de récupérer l'image
                FileStream stream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                // Ajoute l'image à la picture box
                imgTalentTree.Image = Image.FromStream(stream);
                // Ferme le flux
                stream.Close();
                // Copy de l'image dans le dossier de sauvegarde
                File.Copy(openFileDialog.FileName, Application.StartupPath + "\\images\\" + formProfil.profiles[formProfil.index].getName() + ".jpg", true);
            }
        }
    }
}
