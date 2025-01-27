﻿namespace ReadAoe2Recrod
{
    public static class Aoe2Mapper
    {
        public static string ParseGameTypeShort(int id)
        {
            if (id == 0) return "RM";
            if (id == 1) return "RE";
            if (id == 2) return "DM";
            if (id == 3) return "SC";
            if (id == 4) return "CP";
            if (id == 5) return "KH";
            if (id == 6) return "WR";
            if (id == 7) return "DWr";
            if (id == 8) return "TR";
            if (id == 10) return "CR";
            if (id == 11) return "SD";
            if (id == 12) return "BR";
            if (id == 13) return "EW";
            return "UN";
        }

        public static string ParseGameTypeName(int id)
        {
            if (id == 0) return "Random Map";
            if (id == 1) return "Regicide";
            if (id == 2) return "Deathmatch";
            if (id == 3) return "Scenario";
            if (id == 4) return "Campaign";
            if (id == 5) return "King of the Hill";
            if (id == 6) return "Wonder Race";
            if (id == 7) return "Defend the Wonder";
            if (id == 8) return "Turbo Random";
            if (id == 10) return "Capture the Relic";
            if (id == 11) return "Sudden Death";
            if (id == 12) return "Battle Royale";
            if (id == 13) return "Empire Wars";
            return "Unknown";
        }
        public static string ParseMapName(int id)
        {
            if(id == 9) return "Arabia";
            if(id == 10) return "Archipelago";
            if(id == 11) return "Baltic";
            if(id == 12) return "Black Forest";
            if(id == 13) return "Coastal";
            if(id == 14) return "Continental";
            if(id == 15) return "Crater Lake";
            if(id == 16) return "Fortress";
            if(id == 17) return "Gold Rush";
            if(id == 18) return "Highland";
            if(id == 19) return "Islands";
            if(id == 20) return "Mediterranean";
            if(id == 21) return "Migration";
            if(id == 22) return "Rivers";
            if(id == 23) return "Team Islands";
            if(id == 24) return "Full Random";
            if(id == 25) return "Scandinavia";
            if(id == 26) return "Mongolia";
            if(id == 27) return "Yucatan";
            if(id == 28) return "Salt Marsh";
            if(id == 29) return "Arena";
            if(id == 30) return "King of the Hill";
            if(id == 31) return "Oasis";
            if(id == 32) return "Ghost Lake";
            if(id == 33) return "Nomad";
            if(id == 49) return "Iberia";
            if(id == 50) return "Britain";
            if(id == 51) return "Mideast";
            if(id == 52) return "Texas";
            if(id == 53) return "Italy";
            if(id == 54) return "Central America";
            if(id == 55) return "France";
            if(id == 56) return "Norse Lands";
            if(id == 57) return "Sea of Japan (East Sea)";
            if(id == 58) return "Byzantium";
            if(id == 59) return "Custom";
            if(id == 60) return "Random Land Map";
            if(id == 62) return "Random Real World Map";
            if(id == 63) return "Blind Random";
            if(id == 65) return "Random Special Map";
            if(id == 66) return "Random Special Map";
            if(id == 67) return "Acropolis";
            if(id == 68) return "Budapest";
            if(id == 69) return "Cenotes";
            if(id == 70) return "City of Lakes";
            if(id == 71) return "Golden Pit";
            if(id == 72) return "Hideout";
            if(id == 73) return "Hill Fort";
            if(id == 74) return "Lombardia";
            if(id == 75) return "Steppe";
            if(id == 76) return "Valley";
            if(id == 77) return "MegaRandom";
            if(id == 78) return "Hamburger";
            if(id == 79) return "CtR Random";
            if(id == 80) return "CtR Monsoon";
            if(id == 81) return "CtR Pyramid Descent";
            if(id == 82) return "CtR Spiral";
            if(id == 83) return "Kilimanjaro";
            if(id == 84) return "Mountain Pass";
            if(id == 85) return "Nile Delta";
            if(id == 86) return "Serengeti";
            if(id == 87) return "Socotra";
            if(id == 88) return "Amazon";
            if(id == 89) return "China";
            if(id == 90) return "Horn of Africa";
            if(id == 91) return "India";
            if(id == 92) return "Madagascar";
            if(id == 93) return "West Africa";
            if(id == 94) return "Bohemia";
            if(id == 95) return "Earth";
            if(id == 96) return "Canyons";
            if(id == 97) return "Enemy Archipelago";
            if(id == 98) return "Enemy Islands";
            if(id == 99) return "Far Out";
            if(id == 100) return "Front Line";
            if(id == 101) return "Inner Circle";
            if(id == 102) return "Motherland";
            if(id == 103) return "Open Plains";
            if(id == 104) return "Ring of Water";
            if(id == 105) return "Snakepit";
            if(id == 106) return "The Eye";
            if(id == 107) return "Australia";
            if(id == 108) return "Indochina";
            if(id == 109) return "Indonesia";
            if(id == 110) return "Strait of Malacca";
            if(id == 111) return "Philippines";
            if(id == 112) return "Bog Islands";
            if(id == 113) return "Mangrove Jungle";
            if(id == 114) return "Pacific Islands";
            if(id == 115) return "Sandbank";
            if(id == 116) return "Water Nomad";
            if(id == 117) return "Jungle Islands";
            if(id == 118) return "Holy Line";
            if(id == 119) return "Border Stones";
            if(id == 120) return "Yin Yang";
            if(id == 121) return "Jungle Lanes";
            if(id == 122) return "Alpine Lakes";
            if(id == 123) return "Bogland";
            if(id == 124) return "Mountain Ridge";
            if(id == 125) return "Ravines";
            if(id == 126) return "Wolf Hill";
            if(id == 132) return "Antarctica";
            if(id == 137) return "Custom Map Pool";
            if(id == 139) return "Golden Swamp";
            if(id == 140) return "Four Lakes";
            if(id == 141) return "Land Nomad";
            if(id == 142) return "Battle on Ice";
            if(id == 143) return "El Dorado";
            if(id == 144) return "Fall of Axum";
            if(id == 145) return "Fall of Rome";
            if(id == 146) return "Majapahit Empire";
            if(id == 147) return "Amazon Tunnel";
            if(id == 148) return "Coastal Forest";
            if(id == 149) return "African Clearing";
            if(id == 150) return "Atacama";
            if(id == 151) return "Seize the Mountain";
            if(id == 152) return "Crater";
            if(id == 153) return "Crossroads";
            if(id == 154) return "Michi";
            if(id == 155) return "Team Moats";
            if(id == 156) return "Volcanic Islan";
            if (id == 167) return "Runestones";
            return "Unknown";
        }
        
        public static string ParseCiv(uint id)
        {
            if (id == 1) return "Britons";
            if (id == 2) return "Franks";
            if (id == 3) return "Goths";
            if (id == 4) return "Teutons";
            if (id == 5) return "Japanese";
            if (id == 6) return "Chinese";
            if (id == 7) return "Byzantines";
            if (id == 8) return "Persians";
            if (id == 9) return "Saracens";
            if (id == 10) return "Turks";
            if (id == 11) return "Vikings";
            if (id == 12) return "Mongols";
            if (id == 13) return "Celts";
            if (id == 14) return "Spanish";
            if (id == 15) return "Aztecs";
            if (id == 16) return "Mayans";
            if (id == 17) return "Huns";
            if (id == 18) return "Koreans";
            if (id == 19) return "Italians";
            if (id == 20) return "Hindustanis";
            if (id == 21) return "Incas";
            if (id == 22) return "Magyars";
            if (id == 23) return "Slavs";
            if (id == 24) return "Portuguese";
            if (id == 25) return "Ethiopians";
            if (id == 26) return "Malians";
            if (id == 27) return "Berbers";
            if (id == 28) return "Khmer";
            if (id == 29) return "Malay";
            if (id == 30) return "Burmese";
            if (id == 31) return "Vietnamese";
            if (id == 32) return "Bulgarians";
            if (id == 33) return "Tatars";
            if (id == 34) return "Cumans";
            if (id == 35) return "Lithuanians";
            if (id == 36) return "Burgundians";
            if (id == 37) return "Sicilians";
            if (id == 38) return "Poles";
            if (id == 39) return "Bohemian";
            if (id == 40) return "Dravidians";
            if (id == 41) return "Bengalis";
            if (id == 42) return "Gurjaras";
            
            return "Unknown";
        }
    }
}