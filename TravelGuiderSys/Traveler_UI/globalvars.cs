using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelGuiderLibrary;

namespace Traveler_UI
{
    public static class GlobalVariables
    {
        public static LocationLinkedList LocationList { get; set; } = new LocationLinkedList();
        private static int nextLocationId = 86; // Initialize the next available LocationId

        static GlobalVariables()
        {
            // Initialize the list with some sample locations
            AddSampleLocations();
        }

        private static void AddSampleLocations()
        {
            LocationList.AddLocation(new LocationModel { LocationId = 1, LocationName = "Garadi Ella", District = "Badulla", Budjet = 1500, Description = "One of the best hikes you can do." });
            LocationList.AddLocation(new LocationModel { LocationId = 2, LocationName = "Temple of the Tooth", District = "Kandy", Budjet = 2000, Description = "Temple of the Sacred Tooth Relic, a Buddhist temple in Kandy." });
            LocationList.AddLocation(new LocationModel { LocationId = 3, LocationName = "Diyaluma Falls", District = "Badulla", Budjet = 1800, Description = "A beautiful waterfall located near Koslanda." });
            LocationList.AddLocation(new LocationModel { LocationId = 4, LocationName = "Kandy Lake", District = "Kandy", Budjet = 1200, Description = "A scenic lake in the heart of Kandy city." });
            LocationList.AddLocation(new LocationModel { LocationId = 5, LocationName = "Peradeniya Botanical Gardens", District = "Kandy", Budjet = 2500, Description = "A lush garden known for its vast collection of flora." });
            LocationList.AddLocation(new LocationModel { LocationId = 6, LocationName = "Nuwara Eliya", District = "Nuwara Eliya", Budjet = 3000, Description = "A hill station known for its cool climate and scenic beauty." });
            LocationList.AddLocation(new LocationModel { LocationId = 7, LocationName = "Horton Plains", District = "Nuwara Eliya", Budjet = 3500, Description = "A national park famous for its biodiversity and scenic views." });
            LocationList.AddLocation(new LocationModel { LocationId = 8, LocationName = "Gregory Lake", District = "Nuwara Eliya", Budjet = 2200, Description = "A tranquil lake surrounded by beautiful landscapes." });
            LocationList.AddLocation(new LocationModel { LocationId = 9, LocationName = "Sigiriya Rock Fortress", District = "Matale", Budjet = 5000, Description = "An ancient rock fortress and UNESCO World Heritage site." });
            LocationList.AddLocation(new LocationModel { LocationId = 10, LocationName = "Pidurangala Rock", District = "Matale", Budjet = 4000, Description = "A nearby rock offering panoramic views of Sigiriya." });
            LocationList.AddLocation(new LocationModel { LocationId = 11, LocationName = "Dambulla Cave Temple", District = "Matale", Budjet = 3000, Description = "A complex of caves containing ancient Buddhist murals and statues." });
            LocationList.AddLocation(new LocationModel { LocationId = 12, LocationName = "Anuradhapura", District = "Anuradhapura", Budjet = 4500, Description = "An ancient city and UNESCO World Heritage site." });
            LocationList.AddLocation(new LocationModel { LocationId = 13, LocationName = "Ruwanwelisaya", District = "Anuradhapura", Budjet = 3500, Description = "A sacred stupa and one of the most significant religious sites." });
            LocationList.AddLocation(new LocationModel { LocationId = 14, LocationName = "Sri Maha Bodhi", District = "Anuradhapura", Budjet = 2500, Description = "The sacred fig tree under which Buddha attained enlightenment." });
            LocationList.AddLocation(new LocationModel { LocationId = 15, LocationName = "Trincomalee", District = "Trincomalee", Budjet = 4000, Description = "A coastal city with beautiful beaches and historical significance." });
            LocationList.AddLocation(new LocationModel { LocationId = 16, LocationName = "Nilaveli Beach", District = "Trincomalee", Budjet = 4500, Description = "A pristine beach known for its clear blue waters." });
            LocationList.AddLocation(new LocationModel { LocationId = 17, LocationName = "Fort Frederick", District = "Trincomalee", Budjet = 3700, Description = "A historic fort built by the Portuguese and later used by the Dutch and British." });
            LocationList.AddLocation(new LocationModel { LocationId = 18, LocationName = "Colombo National Museum", District = "Colombo", Budjet = 2000, Description = "A museum showcasing Sri Lanka's cultural history." });
            LocationList.AddLocation(new LocationModel { LocationId = 19, LocationName = "Galle Face Green", District = "Colombo", Budjet = 1000, Description = "A popular oceanfront park in Colombo, perfect for a stroll." });
            LocationList.AddLocation(new LocationModel { LocationId = 20, LocationName = "Gangaramaya Temple", District = "Colombo", Budjet = 1500, Description = "A Buddhist temple known for its blend of modern and traditional architecture." });
            LocationList.AddLocation(new LocationModel { LocationId = 21, LocationName = "Mount Lavinia Beach", District = "Colombo", Budjet = 3000, Description = "A popular beach located just outside Colombo city." });
            LocationList.AddLocation(new LocationModel { LocationId = 22, LocationName = "Pinnawala Elephant Orphanage", District = "Kegalle", Budjet = 4000, Description = "An orphanage and sanctuary for elephants in Sri Lanka." });
            LocationList.AddLocation(new LocationModel { LocationId = 23, LocationName = "Muthurajawela Marsh", District = "Gampaha", Budjet = 2800, Description = "A wetland sanctuary that is home to a variety of wildlife." });
            LocationList.AddLocation(new LocationModel { LocationId = 24, LocationName = "Kanduboda Meditation Centre", District = "Gampaha", Budjet = 3300, Description = "A peaceful meditation center located in the heart of nature." });
            LocationList.AddLocation(new LocationModel { LocationId = 25, LocationName = "Kithulgala", District = "Kegalle", Budjet = 3500, Description = "A scenic town known for adventure activities like white-water rafting." });
            LocationList.AddLocation(new LocationModel { LocationId = 26, LocationName = "Sambar Wildlife Sanctuary", District = "Moneragala", Budjet = 3800, Description = "A protected area home to many species of wildlife." });
            LocationList.AddLocation(new LocationModel { LocationId = 27, LocationName = "Mirissa Beach", District = "Matara", Budjet = 3200, Description = "A beautiful beach famous for whale watching." });
            LocationList.AddLocation(new LocationModel { LocationId = 28, LocationName = "Weligama", District = "Matara", Budjet = 2700, Description = "A coastal town known for its surf breaks." });
            LocationList.AddLocation(new LocationModel { LocationId = 29, LocationName = "Hummanaya Blowhole", District = "Hambantota", Budjet = 5000, Description = "A natural sea water spout located in the southern coast." });
            LocationList.AddLocation(new LocationModel { LocationId = 30, LocationName = "Tangalle Beach", District = "Hambantota", Budjet = 4500, Description = "A serene beach located on the southern coast." });
            LocationList.AddLocation(new LocationModel { LocationId = 31, LocationName = "Yala National Park", District = "Hambantota", Budjet = 8000, Description = "A famous national park known for its wildlife and leopards." });
            LocationList.AddLocation(new LocationModel { LocationId = 32, LocationName = "Udawalawe National Park", District = "Ratnapura", Budjet = 6000, Description = "A popular wildlife sanctuary, particularly for elephant sightings." });
            LocationList.AddLocation(new LocationModel { LocationId = 33, LocationName = "Bopath Ella Falls", District = "Ratnapura", Budjet = 2500, Description = "A stunning waterfall located in the Sabaragamuwa province." });
            LocationList.AddLocation(new LocationModel { LocationId = 34, LocationName = "Adam’s Peak", District = "Ratnapura", Budjet = 5500, Description = "A sacred mountain pilgrimage site for multiple religions." });
            LocationList.AddLocation(new LocationModel { LocationId = 35, LocationName = "Pothuvil", District = "Ampara", Budjet = 3700, Description = "A beautiful coastal town famous for its beaches." });
            LocationList.AddLocation(new LocationModel { LocationId = 36, LocationName = "Kumana National Park", District = "Ampara", Budjet = 4000, Description = "A national park known for its bird watching opportunities." });
            LocationList.AddLocation(new LocationModel { LocationId = 37, LocationName = "Tissamaharama", District = "Hambantota", Budjet = 3000, Description = "A historical town known for its proximity to Yala and Bundala." });
            LocationList.AddLocation(new LocationModel { LocationId = 38, LocationName = "Bandaranaike Memorial International Conference Hall", District = "Colombo", Budjet = 7000, Description = "A prestigious conference hall used for cultural events." });
            LocationList.AddLocation(new LocationModel { LocationId = 39, LocationName = "Galle Fort", District = "Galle", Budjet = 3500, Description = "A colonial-era fort with rich history and stunning views." });
            LocationList.AddLocation(new LocationModel { LocationId = 40, LocationName = "Unawatuna", District = "Galle", Budjet = 2800, Description = "A popular beach destination near Galle." });
            LocationList.AddLocation(new LocationModel { LocationId = 41, LocationName = "Mirissa", District = "Matara", Budjet = 3200, Description = "A beautiful coastal town perfect for whale watching." });
            LocationList.AddLocation(new LocationModel { LocationId = 42, LocationName = "Balangoda", District = "Ratnapura", Budjet = 2200, Description = "A scenic town located in the hill country." });
            LocationList.AddLocation(new LocationModel { LocationId = 43, LocationName = "Bellanwila Rajamaha Viharaya", District = "Colombo", Budjet = 1800, Description = "An important Buddhist temple located in Colombo." });
            LocationList.AddLocation(new LocationModel { LocationId = 44, LocationName = "Elkaduwa", District = "Kandy", Budjet = 2400, Description = "A picturesque village in the hill country known for hiking." });
            LocationList.AddLocation(new LocationModel { LocationId = 45, LocationName = "Gampaha", District = "Gampaha", Budjet = 1900, Description = "A bustling city near Colombo with rich history and natural beauty." });
            LocationList.AddLocation(new LocationModel { LocationId = 46, LocationName = "Kadugannawa", District = "Kandy", Budjet = 2800, Description = "A town known for its historical significance and scenic views." });
            LocationList.AddLocation(new LocationModel { LocationId = 47, LocationName = "Ritigala", District = "Anuradhapura", Budjet = 3000, Description = "An ancient Buddhist monastery located in the Anuradhapura District." });
            LocationList.AddLocation(new LocationModel { LocationId = 48, LocationName = "Kekirawa", District = "Anuradhapura", Budjet = 3200, Description = "A town near the ancient city of Anuradhapura." });
            LocationList.AddLocation(new LocationModel { LocationId = 49, LocationName = "Jaffna Fort", District = "Jaffna", Budjet = 2500, Description = "A historic fort located in the northern city of Jaffna." });
            LocationList.AddLocation(new LocationModel { LocationId = 50, LocationName = "Nallur Kandaswamy Kovil", District = "Jaffna", Budjet = 1500, Description = "A Hindu temple located in Jaffna." });
            LocationList.AddLocation(new LocationModel { LocationId = 51, LocationName = "Kachchativu Island", District = "Jaffna", Budjet = 4000, Description = "A small island located off the northern coast of Sri Lanka." });
            LocationList.AddLocation(new LocationModel { LocationId = 52, LocationName = "Nuwara Eliya Golf Course", District = "Nuwara Eliya", Budjet = 10000, Description = "A historic golf course surrounded by scenic beauty." });
            LocationList.AddLocation(new LocationModel { LocationId = 53, LocationName = "Minneriya National Park", District = "Polonnaruwa", Budjet = 6000, Description = "Famous for its large herds of elephants." });
            LocationList.AddLocation(new LocationModel { LocationId = 54, LocationName = "Polonnaruwa Ancient City", District = "Polonnaruwa", Budjet = 5000, Description = "A UNESCO World Heritage Site showcasing ancient ruins." });
            LocationList.AddLocation(new LocationModel { LocationId = 55, LocationName = "Kandy Royal Palace", District = "Kandy", Budjet = 2500, Description = "The historic royal palace of the Kandy kings." });
            LocationList.AddLocation(new LocationModel { LocationId = 56, LocationName = "Veddha Village", District = "Moneragala", Budjet = 3500, Description = "A visit to the indigenous Veddha tribe." });
            LocationList.AddLocation(new LocationModel { LocationId = 57, LocationName = "Yapahuwa", District = "Kurunegala", Budjet = 3200, Description = "An ancient kingdom site with historic ruins." });
            LocationList.AddLocation(new LocationModel { LocationId = 58, LocationName = "Kurunegala Lake", District = "Kurunegala", Budjet = 2800, Description = "A scenic lake in the city center." });
            LocationList.AddLocation(new LocationModel { LocationId = 59, LocationName = "Lahugala Kitulana National Park", District = "Ampara", Budjet = 3000, Description = "A nature reserve with a rich variety of wildlife." });
            LocationList.AddLocation(new LocationModel { LocationId = 60, LocationName = "Viharamahadevi Park", District = "Colombo", Budjet = 1500, Description = "A large public park in the heart of Colombo city." });
            LocationList.AddLocation(new LocationModel { LocationId = 61, LocationName = "Hikkaduwa Beach", District = "Galle", Budjet = 3800, Description = "A popular tourist beach known for diving and marine life." });
            LocationList.AddLocation(new LocationModel { LocationId = 62, LocationName = "Mihintale", District = "Anuradhapura", Budjet = 2700, Description = "A historic site where Buddhism was introduced to Sri Lanka." });
            LocationList.AddLocation(new LocationModel { LocationId = 63, LocationName = "Ramboda Falls", District = "Nuwara Eliya", Budjet = 2200, Description = "A scenic waterfall on the Nuwara Eliya road." });
            LocationList.AddLocation(new LocationModel { LocationId = 64, LocationName = "Benthota Beach", District = "Kalutara", Budjet = 3200, Description = "A beautiful beach known for its calm waters." });
            LocationList.AddLocation(new LocationModel { LocationId = 65, LocationName = "Sinharaja Rainforest", District = "Ratnapura", Budjet = 5000, Description = "A UNESCO-listed rainforest famous for its biodiversity." });
            LocationList.AddLocation(new LocationModel { LocationId = 66, LocationName = "Kandalama Lake", District = "Dambulla", Budjet = 4000, Description = "A tranquil lake near Dambulla." });
            LocationList.AddLocation(new LocationModel { LocationId = 67, LocationName = "Buduruwagala Temple", District = "Moneragala", Budjet = 2700, Description = "An ancient Buddhist temple known for its giant rock carvings." });
            LocationList.AddLocation(new LocationModel { LocationId = 68, LocationName = "Giritale", District = "Polonnaruwa", Budjet = 3200, Description = "A scenic area near Polonnaruwa known for its nature and serenity." });
            LocationList.AddLocation(new LocationModel { LocationId = 69, LocationName = "Yala National Park", District = "Hambantota", Budjet = 6000, Description = "A famous national park known for its wildlife and leopards." });
            LocationList.AddLocation(new LocationModel { LocationId = 70, LocationName = "Anawilundawa Wetland", District = "Puttalam", Budjet = 2500, Description = "A biosphere reserve located near Puttalam." });
            LocationList.AddLocation(new LocationModel { LocationId = 71, LocationName = "Pettah Market", District = "Colombo", Budjet = 1500, Description = "A busy market area known for its vibrant street life." });
            LocationList.AddLocation(new LocationModel { LocationId = 72, LocationName = "Marawila Beach", District = "Negombo", Budjet = 2200, Description = "A quiet beach with picturesque views." });
            LocationList.AddLocation(new LocationModel { LocationId = 73, LocationName = "Talalla Beach", District = "Matara", Budjet = 3500, Description = "A peaceful beach ideal for swimming and relaxing." });
            LocationList.AddLocation(new LocationModel { LocationId = 74, LocationName = "Arugam Bay", District = "Ampara", Budjet = 5500, Description = "A popular surf spot in Sri Lanka." });
            LocationList.AddLocation(new LocationModel { LocationId = 75, LocationName = "Siri Pada (Adam's Peak)", District = "Ratnapura", Budjet = 4500, Description = "A famous pilgrimage site with breathtaking views." });
            LocationList.AddLocation(new LocationModel { LocationId = 76, LocationName = "Jungle Beach", District = "Galle", Budjet = 1800, Description = "A hidden beach with golden sands and clear waters." });
            LocationList.AddLocation(new LocationModel { LocationId = 77, LocationName = "Japanese Peace Pagoda", District = "Galle", Budjet = 1200, Description = "A serene Buddhist stupa offering panoramic views of the ocean." });
            LocationList.AddLocation(new LocationModel { LocationId = 78, LocationName = "Rumassala Hill", District = "Galle", Budjet = 1500, Description = "A hill with legends from the Ramayana, offering breathtaking views." });
            LocationList.AddLocation(new LocationModel { LocationId = 79, LocationName = "Koggala Lake", District = "Galle", Budjet = 2000, Description = "A scenic lake with islands, birdwatching, and boat rides." });
            LocationList.AddLocation(new LocationModel { LocationId = 80, LocationName = "Handunugoda Tea Estate", District = "Galle", Budjet = 1000, Description = "A tea plantation known for its white tea and factory tours." });
            LocationList.AddLocation(new LocationModel { LocationId = 81, LocationName = "Mihiripenna Beach", District = "Galle", Budjet = 1600, Description = "A tranquil beach ideal for swimming and turtle spotting." });
            LocationList.AddLocation(new LocationModel { LocationId = 82, LocationName = "Dalawella Beach", District = "Galle", Budjet = 1400, Description = "A picturesque beach with famous palm swings and clear waters." });
            LocationList.AddLocation(new LocationModel { LocationId = 83, LocationName = "Ahangama Surf Point", District = "Galle", Budjet = 2200, Description = "A popular surf spot with great waves for all skill levels." });
            LocationList.AddLocation(new LocationModel { LocationId = 84, LocationName = "Kottawa Rainforest", District = "Galle", Budjet = 1800, Description = "A biodiverse rainforest perfect for nature lovers and hikers." });
            LocationList.AddLocation(new LocationModel { LocationId = 85, LocationName = "Martin Wickramasinghe Museum", District = "Galle", Budjet = 1300, Description = "A museum showcasing Sri Lankan literature, culture, and history." });

        }

        public static int GetNextLocationId()
        {
            return nextLocationId++;
        }

        public static void AddLocation(LocationModel location)
        {
            location.LocationId = GetNextLocationId();
            LocationList.AddLocation(location);
        }
    }
}
