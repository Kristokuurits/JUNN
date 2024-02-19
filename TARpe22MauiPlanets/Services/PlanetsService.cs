using TARpe22MauiPlanets.Models;


namespace TARpe22MauiPlanets.Services
{
    internal static class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "  The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the smallest planet in the Solar " +
                "System and the closest to the Sun. Its orbit around the Sun takes " +
                "87.97 Earth days, the shortest of all the Sun's planets. " +
                "It is named after the Roman god Mercurius (Mercury), god " +
                "of commerce, messenger of the gods, and mediator between gods " +
                "and mortals, corresponding to the Greek god Hermes (Ἑρμῆς). Like " +
                "Venus, Mercury orbits the Sun within Earth's orbit as an inferior " +
                "planet; its apparent distance from the Sun as viewed from Earth " +
                "never exceeds 28°.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/73_carousel_mercury_2.jpg",
                    "https://science.nasa.gov/_ipx/w_2048&f_webp/https://smd-cms.nasa.gov/wp-content/uploads/2023/05/pia19422-mercury.jpg"
                }
            },

            new()
            {
                Name = "Venus",
                Subtitle = "  The pressure cooker",
                HeroImage = "venus.png",
                Description = "Venus is the second planet from the Sun. It is sometimes " +
                "called Earth's \"sister\" or \"twin\" planet as it is almost as large " +
                "and has a similar composition. As an interior planet to Earth, Venus " +
                "(like Mercury) appears in Earth's sky never far from the Sun, either as " +
                "morning star or evening star. Aside from the Sun and Moon, Venus is the " +
                "brightest natural object in Earth's sky, capable of casting visible " +
                "shadows on Earth in dark conditions and being visible to the naked eye " +
                "in broad daylight.",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/143_Venus-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/147_Hubble_Venus_Clouds-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/146_venus_carousel_3.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/144_PIA00485_Venus_Caldera-800.jpg"
                }
            },

            new()
            {
                Name = "Earth",
                Subtitle = "  The cradle of life",
                HeroImage = "earth.png",
                Description = "Earth is the third planet from the Sun and the " +
                "only place known in the universe where life has originated and " +
                "found habitability. While Earth may not contain the largest " +
                "volumes of water in the Solar System, only Earth sustains liquid " +
                "surface water, extending over 70.8% of the Earth with its ocean, " +
                "making Earth an ocean world. Earth's polar regions currently " +
                "retain most of all other water with large sheets of ice covering " +
                "ocean and land, dwarfing Earth's groundwater, lakes, rivers and " +
                "atmospheric water.",
                AccentColorStart = Color.FromArgb("#0e3d68"),
                AccentColorEnd = Color.FromArgb("#2e97c7"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/68_epicearthmoonstill_800.png",
                    "https://solarsystem.nasa.gov/system/feature_items/images/69_earth_carousel_3.jpg",
                    "https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778"
                }
            },

                        new()
            {
                Name = " Mars",
                Subtitle = "  The iron planet",
                HeroImage = "mars.png",
                Description = "Mars is the fourth planet from the Sun – a dusty, " +
                            "cold, desert world with a very thin atmosphere. " +
                            "Mars is also a dynamic planet with seasons, polar " +
                            "ice caps, canyons, extinct volcanoes, and evidence " +
                            "that it was even more active in the past.",
                AccentColorStart = Color.FromArgb("#a23036"),
                AccentColorEnd = Color.FromArgb("#eb3333"),
                Images = new()
                {
                    "https://researchfdi.com/wp-content/uploads/2021/10/8944_1-PIA24546-1280.jpeg",
                    "https://www.worldatlas.com/r/w1300-q80/upload/bb/c3/32/shutterstock-1041249343.jpg",
                    "https://www.openaccessgovernment.org/wp-content/uploads/2021/04/dreamstime_xxl_121672573-scaled.jpg"
                }
            },

            new()
            {
                Name = " Jupiter",
                Subtitle = "  The gas giant",
                HeroImage = "jupiter.png",
                Description = "Jupiter is the fifth planet from the Sun and " +
                "the largest in the Solar System. It is a gas giant with " +
                "a mass more than two and a half times that of all the " +
                "other planets in the Solar System combined, and slightly " +
                "less than one one-thousandth the mass of the Sun.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/11_Full_Jupiter-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/10_Jupiter_Io_Juno-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/13_PIA24237_Jupiter_Cyclones-800.jpg"
                }
            },

                        new()
            {
                Name = " Saturn",
                Subtitle = "  The ring planet",
                HeroImage = "saturn.png",
                Description = "Saturn is the sixth planet from the Sun and " +
                            "the second-largest in the Solar System, after " +
                            "Jupiter. It is a gas giant with an average " +
                            "radius of about nine and a half times that " +
                            "of Earth. It has only one-eighth the average " +
                            "density of Earth, but is over 95 times more massive.",
                AccentColorStart = Color.FromArgb("#996237"),
                AccentColorEnd = Color.FromArgb("#c6502f"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/151_saturn_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/152_saturn_carousel_2.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/155_saturn_carousel_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/153_saturn_carousel_3.jpg"
                }
            },

            new()
            {
                Name = " Uranus",
                Subtitle = "  The Herschel planet",
                HeroImage = "uranus.png",
                Description = "Uranus is the seventh planet from the Sun. " +
                "It is named after Greek sky deity Uranus (Caelus), who in " +
                "Greek mythology is the father of Cronus (Saturn), a grandfather " +
                "of Zeus (Jupiter) and great-grandfather of Ares (Mars). Uranus " +
                "has the third-largest planetary radius and fourth-largest " +
                "planetary mass in the Solar System.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/89_uranus_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg"
                }
            },

            new()
            {
                Name = " Neptune",
                Subtitle = "  The god of the sea",
                HeroImage = "neptune.png",
                Description = "Neptune is the eighth planet from the Sun and " +
                "the farthest known planet in the Solar System. It is the " +
                "fourth-largest planet in the Solar System by diameter, the " +
                "third-most-massive planet, and the densest giant planet. " +
                "It is 17 times the mass of Earth, and slightly more " +
                "massive than its near-twin Uranus.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/82_carousel_neptune_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/86_carousel_neptune_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/84_neptune_carousel_2.jpg"
                }
            },

            new()
            {
                Name = " Pluuto",
                Subtitle = "  dwarf planet",
                HeroImage = "Pluuto.png",
                Description = "Pluto is a dwarf planet." +
                "A dwarf planet is round and orbits the sun just like the eight major planets of the solar system." +
                "A dwarf planet also is much smaller than a planet, but it is not a moon because a dwarf planet orbits the sun." +
                "On average, Pluto is a distance of 39.5 astronomical units, or AU, from the sun." +
                "That is almost 40 times farther from the sun than Earth is." +
                "Because of its elliptical orbit, Pluto is not the same distance from the sun all the time." +
                "Pluto’s closest point to the sun is 29.7 AU." +
                "Getting this close means that Pluto sometimes crosses Neptune’s path. Neptune is 30 AU from the sun." +
                "Pluto’s farthest point away from the sun is 49.3 AU." +
                "Pluto is in a region called the Kuiper (KY-per) Belt." +
                "The Kuiper Belt is a large donut of thousands of small, icy objects that orbit the sun beyond Neptune.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/82_carousel_neptune_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/86_carousel_neptune_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/84_neptune_carousel_2.jpg"
                }
            },

            new()
            {
                Name = " Ceres",
                Subtitle = "  dwarf planet",
                HeroImage = "Pluuto.png",
                Description = "Ceres was the first object discovered in the main asteroid belt and is named for the Roman goddess of agriculture." +
                "Italian astronomer Father Giuseppe Piazzi spotted the object in 1801." +
                "Ceres was initially classified as a planet and later classified as an asteroid as more objects were found in the same region." +
                "In recognition of its planet-like qualities, Ceres was designated a dwarf planet in 2006 along with Pluto and Eris." +
                "NASA's Hubble Space Telescope observations in 2003 and 2004 of Ceres as it rotated demonstrated that is a nearly spherical body." +
                "Ceres is approximately 585 miles (940 kilometers) across." +
                "Ceres comprises 35 percent of the main asteroid belt's total mass.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/82_carousel_neptune_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/86_carousel_neptune_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/84_neptune_carousel_2.jpg"
                }
            },

            new()
            {
                Name = " Haumea",
                Subtitle = "  dwarf planet",
                HeroImage = "Pluuto.png",
                Description = "Haumea (sümbol: )[1] on Päikesesüsteemi viies kääbusplaneet, mis avastati 2005. aastal 2003. aastal tehtud fotode analüüsi käigus ning oli seni tuntud vaid koodi 2003 EL61 järgi." +
                "Kääbusplaneet on saanud nime havai maa- ja viljakusjumalanna Haumea auks." +
                "Haumea on munakujuline taevakeha, mille mõõtmed on võrreldavad Pluuto omadega." +
                "Selle piklik kuju võib astronoomide arvates tulla kiirest pöörlemisest, mille on põhjustanud miljardite aastate tagune kokkupõrge mõne muu objektiga.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/82_carousel_neptune_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/86_carousel_neptune_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/84_neptune_carousel_2.jpg"
                }
            },
    };

        public static List<Planet> GetFeaturedPlanets()
        {
            var random = new Random();
            var randomizedPlanets = planets.OrderBy(item => random.Next());

            return randomizedPlanets.Take(2).ToList();
        }

        public static List<Planet> GetAllPlanets()
            => planets;
    }
}
