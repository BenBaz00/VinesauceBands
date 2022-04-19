using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VinesauceBands.Models
{
    public static class DbInitializer
    {
        public static void Initialize(VineBandFactory context)
        {
            context.Database.EnsureCreated();

            // Check if seeded
            if (context.Albums.Any())
            {
                return;
            }

            // Add Red Vox
            context.Bands.Add(new Band()
            {
                BandID = 1,
                BandName = "Red Vox",
            });

            string[] redvoxNames = {"What Could Go Wrong", "Blood Bagel", "Another Light", "Kerosene", "Realign" };
            int[] redvoxYears = { 2016, 2016, 2017, 2019, 2020 };

            for (int i=1; i <= redvoxNames.Length; i++)
            {
                context.Albums.Add(new Album() 
                {
                    AlbumID = i,
                    BandID = 1,
                    Title = redvoxNames[i-1],
                    Year = redvoxYears[i-1],
                });
            }

            // What Could Go Wrong Songs
            string[] goWrong = { "There She Goes", "Atom Bomb", "We Had A Little Talk", "Back To School", "Telephone", "The Wrong Side of History", "Along The Way", "Hazy", "Job In The City", "She Missed The Beat", "Ghost Page", "Long Lonely Night", "In A Dream"};
            for (int i = 0; i < goWrong.Length; i++)
            {
                context.Songs.Add(new Song()
                {
                    SongTitle = goWrong[i],
                    AlbumID = 1,
                    Comments = new List<Comment>(),
                });
            }
            // Blood Bagel Songs
            string[] bloodBagel = { "Vomit In The Ball Pit", "Roid Rage", "Tired of Love", "Fuck", "Between The Cheeks" };
            for (int i = 0; i < bloodBagel.Length; i++)
            {
                context.Songs.Add(new Song()
                {
                    SongTitle = bloodBagel[i],
                    AlbumID = 2,
                    Comments = new List<Comment>(),
                });
            }
            // Another Light Songs
            string[] anotherLight = {"Another Light", "Settle for Less", "Memories Lie", "Tell Me", "I'm So Happy", "I'm So Sad", "Memento Mori", "From the Stars", "Rub Your Eyes", "Reno", "In the Garden", "Forgive and Forget", "Burn a Picture", "From The Stars"};
            for (int i = 0; i < anotherLight.Length; i++)
            {
                context.Songs.Add(new Song()
                {
                    SongTitle = anotherLight[i],
                    AlbumID = 3,
                    Comments = new List<Comment>(),
                });
            }
            // Kerosene Songs
            string[] kerosene = {"Define Me", "Foot In The Door", "Kerosene", "Running To Forget", "Never Gonna Win", "Heavy Little Heart", "Leave Me Alone", "Why Die On a Hill?", "Hungry Ghost", "Cemetery Window"};
            for (int i = 0; i < kerosene.Length; i++)
            {
                context.Songs.Add(new Song()
                {
                    SongTitle = kerosene[i],
                    AlbumID = 4,
                    Comments = new List<Comment>(),
                });
            }
            // Realign Songs
            string[] realign = {"Realign", "Why Can't This Be Easy", "Reeling From The Rafters", "The Reason This Is Happening", "Apathetic Empathy", "Be Someone Forever", "Ozymandias", "Far Away", "Return The Call", "I Don't Mean To Complain", "Anethesia", "Better On The Outside", "Closer Now", "Pale Blue Dot"};
            for (int i = 0; i < realign.Length; i++)
            {
                context.Songs.Add(new Song()
                {
                    SongTitle = realign[i],
                    AlbumID = 5,
                    Comments = new List<Comment>(),
                });
            }

            // Add Vargskelethor
            context.Bands.Add(new Band()
            {
                BandID = 2,
                BandName = "Vargskelethor",
            });

            string[] VargNames = {"The Revnarok - Fifty Songs About Rev", "Skeleton Metal", "Skeleton Metal 2", "Super Ghostbusters", "Skeleton Metal III"};
            int[] VargYears = { 2014, 2014, 2015, 2018, 2019 };

            for(int i=1; i<= VargNames.Length; i++)
            {
                context.Albums.Add(new Album()
                {
                    AlbumID = i+5,
                    BandID = 2,
                    Title = VargNames[i-1],
                    Year = VargYears[i-1],
                });
            }

            // Revnarok Songs
            string[] revnarok = {"Rev Is Shit", "You Suck(Rev)", "Spermbank Robber", "You Are Literally Shit Rev", "Rev Thinks the Beatles Are Death Metal", "Its Called Soda, Not Pop You Asshole", "Okay Maybe You Call It Coke Instead Whatever", "Your Full Name Sounds like Colon Muffin", "Texas Sucks (And So Do You)", 
                "I'm Going to Nuke Your Face", "I Hired Ninjas to Kill You Rev", "I'm Going to Chainsaw Your Dick Off", "I Hope You Get Hit by a Meteor", "A Message from Rev", "A Ballad for Rev", "I'm Going to Shoot You in the Face with Flamethrower", "Rev Walking to a Store", "I'll Create a Teleportation Device Just to Punch You in the Face Out of Nowhere", 
                "Breaking My Butt (Judas Priest cover)", "I'm Friends with Satan Himself", "I'm Going to Befriends Dolphins So They Can Kill You", "I'm Going to Buy a Sword and Cut You in the Face Maybe", "The Rev Symphony", "I Bribed Santa Clause to Not Give You Any Presents", "Bohemian Revpsody (Queen Cover)", "I Bet You Smell Your Own Farts with That Gasmask", 
                "Dracula Is My Uncle So You Better Watch Out", "Rev Once Went Back in Time to Fuck Himself", "You Are Not Invited to Any of My Pizza Parties Asshole", "I'll Kick Your Face Off", "I'm Going to Feed You to Cannibals (Keytar Song)", "You Don't Even Know What Snow Is You Dick", "Destination Masturbation", "If You Ever Set Foor in Sweden I Will Rip Your Asshole Out", 
                "You're Only Invested in Politics Because You're Attracted to Barack Obama", "Rev Thinks Elvis Presley is Black Metal", "I'll Strap You to a Rocket and Make It Fly into the Sun", "Rev Isn't Actually Tall, He Fakes It with Stilts", "How Dare You Call Me Dumb, That's Mean", "Rev's Top Hat Is Actually a Dildo", "Rev's Favorite Band Is Limp Bizkit", "Breakfast Tacos Are the Dumbest Thing You've Told Me About", 
                "The Shortest Song on the Album", "Rev Likes Mustard on His Chips, and That's Gross", "You're a Man, Yet You're Always on Your Period", "Poopface Dumbass, That's You", "The Heaviest Song on the Album", "Rev's Beard Is Actually Roadkill He Glued to His Face", "I'm Just Joking You're a Cool Guy", "Just Kidding You're a Fucking Asshole"};
            for (int i = 0; i < revnarok.Length; i++)
            {
                context.Songs.Add(new Song()
                {
                    SongTitle = revnarok[i],
                    AlbumID = 6,
                    Comments = new List<Comment>(),
                });
            }

            // Skeleton Metal Songs
            string[] skeleMetal = {"Scorpion, Skeleton Ninja (Mortal Kombat Theme)", "Skeletor", "Chased By Skeletons", "Do Skeletons Fart?", "Skeleton Inside Me", "If Skeletons Aquired Guns", "Skeleton Whale", "Skeleton From Space", "Gravelord Nito (Dark Souls)", "Pirate Skeletons", "Are Mummies Skeletons?"};
            for (int i = 0; i < skeleMetal.Length; i++)
            {
                context.Songs.Add(new Song()
                {
                    SongTitle = skeleMetal[i],
                    AlbumID = 7,
                    Comments = new List<Comment>(),
                });
            }

            // Skeleton Metal 2 Songs
            string[] skeleMetal2 = {"The Bone Zone", "Vampire Skeleton", "United States Of Skeletons", "Reanimated Dinosaur Bones", "Skeleton Planet", "Time Traveling Metal Skeleton", "Are Liches Skeletons?"};
            for (int i = 0; i < skeleMetal2.Length; i++)
            {
                context.Songs.Add(new Song()
                {
                    SongTitle = skeleMetal2[i],
                    AlbumID = 8,
                    Comments = new List<Comment>(),
                });
            }

            // Super Ghostbusters Songs
            string[] superGhost = {"Ghostbusters", "Ghost Buster", "Ghostbusterz", "Ghost-Boster", "Ghastbistin", "Ghostbusterss", "Ghustbusters", "Gostboster", "Ghostabusta", "Ghooooostbuster", "Ghostingbust", "Ghostbatista", "Gheestobesto", "Ghastbasters", "Ghestbest", "Ghosttbusters", "Ghost Bast", "Ghoostbuusters", "Ghosterboster", "Ghstbstrs", "Ghost Bus-Ters", "Ghost Boston", "Ghostboster", "Ghost Bologna"};
            for (int i = 0; i < superGhost.Length; i++)
            {
                context.Songs.Add(new Song()
                {
                    SongTitle = superGhost[i],
                    AlbumID = 9,
                    Comments = new List<Comment>(),
                });
            }

            // Skeleton Metal III Songs
            string[] skeleMetal3 = {"Open Your Coffin", "Necromancer (Kicked Out of Wizard School)", "Viral Warfare", "Bone Pit", "Church Of Skeletons", "The Skull Goblet", "Skeleton Killer", "Speed Metal Spooker", "Skeleton Treasure", "Boner", "Oh Fuck", "Funny Bones", "Glass Of Milk", "Over My Dead Body", "Dia de Muertos", "The Calcium Cataclysm", "Save A Bone For Me"};
            for (int i = 0; i < skeleMetal3.Length; i++)
            {
                context.Songs.Add(new Song()
                {
                    SongTitle = skeleMetal3[i],
                    AlbumID = 10,
                    Comments = new List<Comment>(),
                });
            }

            // Add Scythelord
            context.Bands.Add(new Band()
            {
                BandID = 3,
                BandName = "Scythelord",
            });

            string[] ScytheNames = {"Toxic Minds", "Asclepius"};
            int[] ScytheYears = {2016, 2019};

            for (int i = 1; i <= ScytheNames.Length; i++)
            {
                context.Albums.Add(new Album()
                {
                    AlbumID = i + 10,
                    BandID = 3,
                    Title = ScytheNames[i - 1],
                    Year = ScytheYears[i - 1],
                });
            }

            // Toxic Minds Songs
            string[] toxMinds = {"Oath to Retribution", "Toxic Minds", "Masquerade of Hate", "Die for Nothing", "The Flail of God (Warlord)", "Palace of Glass", "Bloodshed at Dawn", "War at Sanity's End", "Red Shift", "Scythelord"};
            for (int i = 0; i < toxMinds.Length; i++)
            {
                context.Songs.Add(new Song()
                {
                    SongTitle = toxMinds[i],
                    AlbumID = 11,
                    Comments = new List<Comment>(),
                });
            }

            // Asclepius Songs
            string[] asclepius = {"Asclepius", "Mission To The Andes"};
            for (int i = 0; i < asclepius.Length; i++)
            {
                context.Songs.Add(new Song()
                {
                    SongTitle = asclepius[i],
                    AlbumID = 12,
                    Comments = new List<Comment>(),
                });
            }

            context.SaveChanges();
        }
    }
}
