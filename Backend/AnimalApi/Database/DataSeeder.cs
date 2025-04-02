
namespace AnimalApi.Data
{
    public class DataSeeder
    {
        private AnimalDb _db;

        public DataSeeder(AnimalDb db){
            _db = db;
        }
        public void SeedData(){
            
            {
                if(_db.Animals.Any()){
                    return;
                }
                _db.Animals.AddRange(
                    new Animal {
                        Id = 1,
                        Image = "https://images.unsplash.com/photo-1615824996195-f780bba7cfab?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Tiger",
                        Species = "Mammal",
                        Environment = ["Rain forest", "Savanna"],
                        FoodPreference = "Carnivore",
                        Description = "The tiger (Panthera tigris) is a large cat and a member of the genus Panthera native to Asia. It has a powerful, muscular body with a large head and paws, a long tail and orange fur with black, mostly vertical stripes. It is traditionally classified into nine recent subspecies, though some recognise only two subspecies, mainland Asian tigers and the island tigers of the Sunda Islands."
                    },
                    new Animal {
                        Id = 2,
                        Image = @"https://images.unsplash.com/photo-1566544496485-02b11e54229b?q=80&w=2069&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Jaguar",
                        Species = "Mammal",
                        Environment = ["Rain forest", "Swamps"],
                        FoodPreference = "Carnivore",
                        Description = "The jaguar (Panthera onca) is a large cat species and the only living member of the genus Panthera that is native to the Americas. With a body length of up to 1.85 m (6 ft 1 in) and a weight of up to 158 kg (348 lb), it is the biggest cat species in the Americas and the third largest in the world. Its distinctively marked coat features pale yellow to tan colored fur covered by spots that transition to rosettes on the sides, although a melanistic black coat appears in some individuals. The jaguar's powerful bite allows it to pierce the carapaces of turtles and tortoises, and to employ an unusual killing method: it bites directly through the skull of mammalian prey between the ears to deliver a fatal blow to the brain."
                    },
                    new Animal {
                        Id = 3,
                        Image = @"https://images.unsplash.com/photo-1604165645922-eb8fdc7d84ee?q=80&w=2127&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Sloth",
                        Species = "Mammal",
                        Environment = ["Rain forest"],
                        FoodPreference = "Herbivore",
                        Description = "Sloths are a Neotropical group of xenarthran mammals constituting the suborder Folivora, including the extant arboreal tree sloths and extinct terrestrial ground sloths. Noted for their slowness of movement, tree sloths spend most of their lives hanging upside down in the trees of the tropical rainforests of South America and Central America. Sloths are considered to be most closely related to anteaters, together making up the xenarthran order Pilosa."
                    },
                    new Animal {
                        Id = 4,
                        Image = @"https://images.unsplash.com/photo-1581281863883-2469417a1668?q=80&w=1951&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Gorilla",
                        Species = "Mammal",
                        Environment = ["Rain forest"],
                        FoodPreference = "Herbivore",
                        Description = "Gorillas are herbivorous, predominantly ground-dwelling great apes that inhabit the tropical forests of equatorial Africa. The genus Gorilla is divided into two species: the eastern gorilla and the western gorilla, and either four or five subspecies. The DNA of gorillas is highly similar to that of humans, from 95 to 99% depending on what is included, and they are the next closest living relatives to humans after chimpanzees."
                    },
                    new Animal {
                        Id = 5,
                        Image = @"https://images.unsplash.com/photo-1616902509409-a624c4f31a56?q=80&w=2083&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Macaw",
                        Species = "Bird",
                        Environment = ["Rain forest"],
                        FoodPreference = "Herbivore",
                        Description = "Macaws are a group of New World parrots that are long-tailed and often colorful, in the tribe Arini.[1] They are popular in aviculture or as companion parrots, although there are conservation concerns about several species in the wild."
                    },
                    new Animal {
                        Id = 6,
                        Image = @"https://images.unsplash.com/photo-1619038779484-a27362fb82cd?q=80&w=1935&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Toucan",
                        Species = "Bird",
                        Environment = ["Rain forest"],
                        FoodPreference = "Omnivore",
                        Description = "Toucans (/ˈtuːkæn/, UK: /-kən/) are Neotropical birds in the family Ramphastidae. They are most closely related to the Toucan barbets. They are brightly marked and have large, often colorful bills. The family includes five genera and over 40 different species."
                    },
                    new Animal {
                        Id = 7,
                        Image = @"https://images.unsplash.com/photo-1714622343884-7494d44b30fa?q=80&w=1964&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Capybara",
                        Species = "Mammal",
                        Environment = ["Rain forest", "Marshes", "Swamps"],
                        FoodPreference = "Herbivore",
                        Description = "The capybara[a] or greater capybara (Hydrochoerus hydrochaeris) is the largest living rodent,[2] native to South America. It is a member of the genus Hydrochoerus. The only other extant member is the lesser capybara (Hydrochoerus isthmius). Its close relatives include guinea pigs and rock cavies, and it is more distantly related to the agouti, the chinchilla, and the nutria. The capybara inhabits savannas and dense forests, and lives near bodies of water. It is a highly social species and can be found in groups as large as 100 individuals, but usually live in groups of 10–20 individuals. The capybara is hunted for its meat and hide and also for grease from its thick fatty skin.[3]"
                    },
                    new Animal {
                        Id = 8,
                        Image = @"https://images.unsplash.com/photo-1726754412634-fa5d1eb89636?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Howler Monkey",
                        Species = "Mammal",
                        Environment = ["Rain forest"],
                        FoodPreference = "Herbivore",
                        Description = "Howler monkeys (genus Alouatta, monotypic in subfamily Alouattinae) are the most widespread primate genus in the Neotropics and are among the largest of the platyrrhines along with the muriquis (Brachyteles), the spider monkeys (Ateles) and woolly monkeys (Lagotrix). The monkeys are native to South and Central American forests. They are famous for their loud howls, which can be heard up to three miles away through dense rain forest. Fifteen species are recognized. Previously classified in the family Cebidae, they are now placed in the family Atelidae. They are primarily folivores but also significant frugivores, acting as seed dispersal agents through their digestive system and their locomotion. Threats include human predation, habitat destruction, illegal wildlife trade, and capture for pets or zoo animals."
                    },
                    new Animal {
                        Id = 9,
                        Image = @"https://images.unsplash.com/photo-1575590364024-614acdbcbcfc?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Spider monkey",
                        Species = "Mammal",
                        Environment = ["Rain forest"],
                        FoodPreference = "Herbivore",
                        Description = "Spider monkeys are New World monkeys belonging to the genus Ateles, part of the subfamily Atelinae, family Atelidae. Like other atelines, they are found in tropical forests of Central and South America, from southern Mexico to Brazil. The genus consists of seven species, all of which are under threat; the brown spider monkey is critically endangered. They are also notable for their ability to be easily bred in captivity."
                    },
                    new Animal {
                        Id = 10,
                        Image = @"https://images.unsplash.com/photo-1710814449080-41c9e533e22d?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Emerald tree boa",
                        Species = "Reptile",
                        Environment = ["Rain forest"],
                        FoodPreference = "Carnivore",
                        Description = "The emerald tree boa (Corallus caninus) is a boa species found in the rainforests of South America. Since 2009 the species Corallus batesii has been distinguished from the emerald tree boa. Like all other boas, it is nonvenomous. Trade of the species is controlled internationally under CITES Appendix II."
                    },
                    new Animal {
                        Id = 11,
                        Image = @"https://images.unsplash.com/photo-1611069648374-733e7bb73e5c?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Crocodile",
                        Species = "Reptile",
                        Environment = ["Savanna", "Rivers"],
                        FoodPreference = "Carnivore",
                        Description = ""
                    },
                    new Animal {
                        Id = 12,
                        Image = @"https://images.unsplash.com/photo-1546182990-dffeafbe841d?q=80&w=2059&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Lion",
                        Species = "Mammal",
                        Environment = ["Savanna", "Grasslands"],
                        FoodPreference = "Carnivore",
                        Description = "The lion (Panthera leo) is a large cat of the genus Panthera, native to Africa and India. It has a muscular, broad-chested body; a short, rounded head; round ears; and a dark, hairy tuft at the tip of its tail. It is sexually dimorphic; adult male lions are larger than females and have a prominent mane. It is a social species, forming groups called prides. A lion's pride consists of a few adult males, related females, and cubs. Groups of female lions usually hunt together, preying mostly on medium-sized and large ungulates. The lion is an apex and keystone predator."
                    },
                    new Animal {
                        Id = 13,
                        Image = @"https://images.unsplash.com/photo-1534567110243-8875d64ca8ff?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Giraffe",
                        Species = "Mammal",
                        Environment = ["Savanna"],
                        FoodPreference = "Herbivore",
                        Description = "The giraffe is a large African hoofed mammal belonging to the genus Giraffa. It is the tallest living terrestrial animal and the largest ruminant on Earth. Traditionally, giraffes have been thought of as one species, Giraffa camelopardalis, with nine subspecies. Most recently, researchers proposed dividing them into four extant species due to new research into their mitochondrial and nuclear DNA, and individual species can be distinguished by their fur coat patterns. Six valid extinct species of Giraffa from Africa and Pakistan are known from the fossil record."
                    },
                    new Animal {
                        Id = 14,
                        Image = @"https://images.unsplash.com/photo-1581852017103-68ac65514cf7?q=80&w=2073&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Elephant",
                        Species = "Mammal",
                        Environment = ["Savanna", "Wetlands", "Grasslands"],
                        FoodPreference = "Herbivore",
                        Description = "Elephants are the largest living land animals. Three living species are currently recognised: the African bush elephant (Loxodonta africana), the African forest elephant (L. cyclotis), and the Asian elephant (Elephas maximus). They are the only surviving members of the family Elephantidae and the order Proboscidea; extinct relatives include mammoths and mastodons. Distinctive features of elephants include a long proboscis called a trunk, tusks, large ear flaps, pillar-like legs, and tough but sensitive grey skin. The trunk is prehensile, bringing food and water to the mouth and grasping objects. Tusks, which are derived from the incisor teeth, serve both as weapons and as tools for moving objects and digging. The large ear flaps assist in maintaining a constant body temperature as well as in communication. African elephants have larger ears and concave backs, whereas Asian elephants have smaller ears and convex or level backs."
                    },
                    new Animal {
                        Id = 15,
                        Image = @"https://images.unsplash.com/photo-1513109513338-3388e3b82e8a?q=80&w=2069&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Hyena",
                        Species = "Mammal",
                        Environment = ["Savanna", "Grasslands"],
                        FoodPreference = "Carnivore",
                        Description = "Hyenas or hyaenas from Ancient Greek ὕαινα, hýaina) are feliform carnivoran mammals belonging to the family Hyaenidae. With just four extant species (each in its own genus), it is the fifth-smallest family in the order Carnivora and one of the smallest in the class Mammalia. Despite their low diversity, hyenas are unique and vital components of most African ecosystems."
                    },
                    new Animal {
                        Id = 16,
                        Image = @"https://images.unsplash.com/photo-1624958319297-d1aa3a41378e?q=80&w=2080&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Cheetah",
                        Species = "Mammal",
                        Environment = ["Savanna", "Grasslands"],
                        FoodPreference = "Carnivore",
                        Description = "The cheetah (Acinonyx jubatus) is a large cat and the fastest land animal. It has a tawny to creamy white or pale buff fur that is marked with evenly spaced, solid black spots. The head is small and rounded, with a short snout and black tear-like facial streaks. It reaches 67–94 cm (26–37 in) at the shoulder, and the head-and-body length is between 1.1 and 1.5 m (3 ft 7 in and 4 ft 11 in). Adults weigh between 21 and 65 kg (46 and 143 lb). The cheetah is capable of running at 93 to 104 km/h (58 to 65 mph); it has evolved specialized adaptations for speed, including a light build, long thin legs and a long tail."
                    },
                    new Animal {
                        Id = 17,
                        Image = @"https://images.unsplash.com/photo-1517118828960-de5ea37d8ae6?q=80&w=2080&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Wildebeest",
                        Species = "Mammal",
                        Environment = ["Savanna", "Plains"],
                        FoodPreference = "Herbivore",
                        Description = "Wildebeest, also called gnu are antelopes of the genus Connochaetes and native to Eastern and Southern Africa. They belong to the family Bovidae, which includes true antelopes, cattle, goats, sheep, and other even-toed horned ungulates. There are two species of wildebeest: the black wildebeest or white-tailed gnu (C. gnou), and the blue wildebeest or brindled gnu (C. taurinus)."
                    },
                    new Animal {
                        Id = 18,
                        Image = @"https://images.unsplash.com/photo-1562426772-f7b1d159764b?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Hippo",
                        Species = "Mammal",
                        Environment = ["Savanna", "Rivers", "Lakes"],
                        FoodPreference = "Herbivore",
                        Description = "The hippopotamus (Hippopotamus amphibius) often shortened to hippo (pl.: hippos), further qualified as the common hippopotamus, Nile hippopotamus and river hippopotamus, is a large semiaquatic mammal native to sub-Saharan Africa. It is one of only two extant species in the family Hippopotamidae, the other being the pygmy hippopotamus (Choeropsis liberiensis or Hexaprotodon liberiensis). Its name comes from the ancient Greek for river horse."
                    },
                    new Animal {
                        Id = 19,
                        Image = @"https://images.unsplash.com/photo-1504296601235-4d6bb2f25320?q=80&w=1984&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Gazelle",
                        Species = "Mammal",
                        Environment = ["Savanna", "Grasslands"],
                        FoodPreference = "Herbivore",
                        Description = "A gazelle is one of many antelope species in the genus Gazella. There are also seven species included in two further genera; Eudorcas and Nanger, which were formerly considered subgenera of Gazella. A third former subgenus, Procapra, includes three living species of Asian gazelles."
                    },
                    new Animal {
                        Id = 20,
                        Image = @"https://images.unsplash.com/photo-1557447928-9a1ca5819ed6?q=80&w=2080&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Baboon",
                        Species = "Mammal",
                        Environment = ["Savanna", "Mountain"],
                        FoodPreference = "Omnivore",
                        Description = "Baboons are primates comprising the genus Papio, one of the 23 genera of Old World monkeys, in the family Cercopithecidae. There are six species of baboon: the hamadryas baboon, the Guinea baboon, the olive baboon, the yellow baboon, the Kinda baboon and the chacma baboon. Each species is native to one of six areas of Africa and the hamadryas baboon is also native to part of the Arabian Peninsula. Baboons are among the largest non-hominoid primates and have existed for at least two million years."
                    },
                    new Animal {
                        Id = 21,
                        Image = @"https://images.unsplash.com/photo-1590787996529-a542c86ca267?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Polar Bear",
                        Species = "Mammal",
                        Environment = ["Arctic", "Tundra"],
                        FoodPreference = "Carnivore",
                        Description = "The polar bear (Ursus maritimus) is a large bear native to the Arctic and nearby areas. It is closely related to the brown bear, and the two species can interbreed. The polar bear is the largest extant species of bear and land carnivore, with adult males weighing 300–800 kg (660–1,760 lb). The species is sexually dimorphic, as adult females are much smaller. The polar bear is white- or yellowish-furred with black skin and a thick layer of fat. It is more slender than the brown bear, with a narrower skull, longer neck and lower shoulder hump. Its teeth are sharper and more adapted to cutting meat. The paws are large and allow the bear to walk on ice and paddle in the water."
                    },
                    new Animal {
                        Id = 22,
                        Image = @"https://images.unsplash.com/photo-1552326731-fa4d01c2f36f?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Emperor Penguin",
                        Species = "Bird",
                        Environment = ["Arctic", "Tundra"],
                        FoodPreference = "Piscivore",
                        Description = "The emperor penguin (Aptenodytes forsteri) is the tallest and heaviest of all living penguin species and is endemic to Antarctica. The male and female are similar in plumage and size, reaching 100 cm (39 in) in length and weighing from 22 to 45 kg (49 to 99 lb). Feathers of the head and back are black and sharply delineated from the white belly, pale-yellow breast and bright-yellow ear patches."
                    },
                    new Animal {
                        Id = 23,
                        Image = @"https://images.unsplash.com/photo-1531098245163-31b7ff3bb701?q=80&w=2013&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Snowy Owl",
                        Species = "Bird",
                        Environment = ["Arctic", "Grasslands"],
                        FoodPreference = "Carnivore",
                        Description = "The snowy owl (Bubo scandiacus), also known as the polar owl, the white owl and the Arctic owl, is a large, white owl of the true owl family. Snowy owls are native to the Arctic regions of both North America and the Palearctic, breeding mostly on the tundra. It has a number of unique adaptations to its habitat and lifestyle, which are quite distinct from other extant owls. One of the largest species of owl, it is the only owl with mainly white plumage. Males tend to be a purer white overall while females tend to have more extensive flecks of dark brown. Juvenile male snowy owls have dark markings that may appear similar to females until maturity, at which point they typically turn whiter. The composition of brown markings about the wing, although not foolproof, is the most reliable technique to age and sex individual snowy owls."
                    },
                    new Animal {
                        Id = 24,
                        Image = @"https://images.unsplash.com/photo-1697030891256-36a3770cddde?q=80&w=1965&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Tuna",
                        Species = "Fish",
                        Environment = ["Ocean", "Atlantic"],
                        FoodPreference = "Piscivore",
                        Description = "A tuna (pl.: tunas or tuna) is a saltwater fish that belongs to the tribe Thunnini, a subgrouping of the Scombridae (mackerel) family. The Thunnini comprise 15 species across five genera, the sizes of which vary greatly, ranging from the bullet tuna (max length: 50 cm or 1.6 ft, weight: 1.8 kg or 4 lb) up to the Atlantic bluefin tuna (max length: 4.6 m or 15 ft, weight: 684 kg or 1,508 lb), which averages 2 m (6.6 ft) and is believed to live up to 50 years."
                    },
                    new Animal {
                        Id = 25,
                        Image = @"https://images.unsplash.com/photo-1612443385720-b4181d2ab928?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Beluga Whale",
                        Species = "Mammal",
                        Environment = ["Arctic", "Ocean"],
                        FoodPreference = "Piscivore",
                        Description = "The beluga whale (Delphinapterus leucas) is an Arctic and sub-Arctic cetacean. It is one of two living members of the family Monodontidae, along with the narwhal, and the only member of the genus Delphinapterus. It is also known as the white whale, as it is the only cetacean to regularly occur with this colour; the sea canary, due to its high-pitched calls; and the melonhead, though that more commonly refers to the melon-headed whale, which is an oceanic dolphin."
                    },
                    new Animal {
                        Id = 26,
                        Image = @"https://images.unsplash.com/photo-1635810766767-ca010af2d77b?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Leopard Seal",
                        Species = "Mammal",
                        Environment = ["Arctic", "Ocean"],
                        FoodPreference = "Carnivore",
                        Description = "The leopard seal (Hydrurga leptonyx), also referred to as the sea leopard, is the second largest species of seal in the Antarctic (after the southern elephant seal). Its only natural predator is the orca. It feeds on a wide range of prey including cephalopods, other pinnipeds, krill, fish, and birds, particularly penguins. It is the only species in the genus Hydrurga. Its closest relatives are the Ross seal, the crabeater seal and the Weddell seal, which together are known as the tribe of Lobodontini seals. The name hydrurga means water worker and leptonyx is the Greek for thin-clawed."
                    },
                    new Animal {
                        Id = 27,
                        Image = @"https://images.unsplash.com/photo-1544982772-d83aeb8cf70f?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Snow Leopard",
                        Species = "Mammal",
                        Environment = ["Arctic", "Mountain", "Tundra"],
                        FoodPreference = "Carnivore",
                        Description = "The snow leopard (Panthera uncia) is a species of large cat in the genus Panthera of the family Felidae. The species is native to the mountain ranges of Central and South Asia. It is listed as Vulnerable on the IUCN Red List because the global population is estimated to number fewer than 10,000 mature individuals and is expected to decline about 10% by 2040. It is mainly threatened by poaching and habitat destruction following infrastructural developments. It inhabits alpine and subalpine zones at elevations of 3,000–4,500 m (9,800–14,800 ft), ranging from eastern Afghanistan, the Himalayas and the Tibetan Plateau to southern Siberia, Mongolia and western China. In the northern part of its range, it also lives at lower elevations."
                    },
                    new Animal {
                        Id = 28,
                        Image = @"https://images.unsplash.com/photo-1607346444518-2abde24da0a0?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Arctic Wolf",
                        Species = "Mammal",
                        Environment = ["Arctic", "Tundra"],
                        FoodPreference = "Carnivore",
                        Description = "The Arctic wolf (Canis lupus arctos), also known as the white wolf, polar wolf, and the Arctic grey wolf, is a subspecies of grey wolf native to the High Arctic tundra of Canada's Queen Elizabeth Islands, from Melville Island to Ellesmere Island. Unlike some populations that move between tundra and forest regions, Arctic wolves spend their entire lives north of the northern treeline. Their distribution to south is limited to the northern fringes of the Middle Arctic tundra on the southern half of Prince of Wales and Somerset Islands. It is a medium-sized subspecies, distinguished from the northwestern wolf by its smaller size, its whiter colouration, its narrower braincase, and larger carnassials. Since 1930, there has been a progressive reduction in size in Arctic wolf skulls, which is likely the result of wolf-dog hybridization."
                    },
                    new Animal {
                        Id = 29,
                        Image = @"https://images.unsplash.com/photo-1562193965-801a55de0998?q=80&w=2067&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Mountain Goat",
                        Species = "Mammal",
                        Environment = ["Arctic", "Mountain"],
                        FoodPreference = "Herbivore",
                        Description = "The mountain goat (Oreamnos americanus), also known as the Rocky Mountain goat, is a cloven-footed mammal that is endemic to the remote and rugged mountainous areas of western North America. A subalpine to truly alpine species, it is a sure-footed climber commonly seen on sheer rock faces, near-vertical cliffs and icy passages. Mountain goats generally avoid venturing down into lower elevations—except during seasonal food shortages or during particularly bad weather—as the extreme elevation which they inhabit is their primary defense against predators such as black and brown bears, pumas and wolves."
                    },
                    new Animal {
                        Id = 30,
                        Image = @"https://images.unsplash.com/photo-1581853230165-b71de20b7f37?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Reindeer",
                        Species = "Mammal",
                        Environment = ["Arctic", "Tundra", "Forest"],
                        FoodPreference = "Herbivore",
                        Description = "The reindeer or caribou (Rangifer tarandus) is a species of deer with circumpolar distribution, native to Arctic, subarctic, tundra, boreal, and mountainous regions of Northern Europe, Siberia, and North America. It is the only representative of the genus Rangifer. More recent studies suggest the splitting of reindeer and caribou into six distinct species over their range."
                    },
                    new Animal {
                        Id = 31,
                        Image = @"https://images.unsplash.com/photo-1586115457457-b3753fe50cf1?q=80&w=1988&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Great White Shark",
                        Species = "Fish",
                        Environment = ["Ocean", "Coastal"],
                        FoodPreference = "Carnivore",
                        Description = "The great white shark (Carcharodon carcharias), also known as the white shark, white pointer, or simply great white, is a species of large mackerel shark which can be found in the coastal surface waters of all the major oceans. It is the only known surviving species of its genus Carcharodon. The great white shark is notable for its size, with the largest preserved female specimen measuring 5.83 m (19.1 ft) in length and around 2,000 kg (4,400 lb) in weight at maturity. However, most are smaller; males measure 3.4 to 4.0 m (11 to 13 ft), and females measure 4.6 to 4.9 m (15 to 16 ft) on average. According to a 2014 study, the lifespan of great white sharks is estimated to be as long as 70 years or more, well above previous estimates, making it one of the longest lived cartilaginous fishes currently known. According to the same study, male great white sharks take 26 years to reach sexual maturity, while the females take 33 years to be ready to produce offspring. Great white sharks can swim at speeds of 25 km/h (16 mph) for short bursts and to depths of 1,200 m (3,900 ft)."
                    },
                    new Animal {
                        Id = 32,
                        Image = @"https://images.unsplash.com/photo-1698472505070-6d3b90afb530?q=80&w=1935&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Sperm Whale",
                        Species = "Piscivore",
                        Environment = ["Ocean", "Deep Ocean", "Arctic"],
                        FoodPreference = "Herbivore",
                        Description = "The sperm whale or cachalot (Physeter macrocephalus) is the largest of the toothed whales and the largest toothed predator. It is the only living member of the genus Physeter and one of three extant species in the sperm whale family, along with the pygmy sperm whale and dwarf sperm whale of the genus Kogia."
                    },
                    new Animal {
                        Id = 33,
                        Image = @"https://images.unsplash.com/photo-1496196614460-48988a57fccf?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Sea Turtle",
                        Species = "Reptile",
                        Environment = ["Ocean", "Beaches"],
                        FoodPreference = "Omnivore",
                        Description = "Sea turtles (superfamily Chelonioidea), sometimes called marine turtles, are reptiles of the order Testudines and of the suborder Cryptodira. The seven existing species of sea turtles are the flatback, green, hawksbill, leatherback, loggerhead, Kemp's ridley, and olive ridley. Six of the seven sea turtle species, all but the flatback, are present in U.S. waters, and are listed as endangered and/or threatened under the Endangered Species Act. All but the flatback turtle are listed as threatened with extinction globally on the IUCN Red List of Threatened Species. The flatback turtle is found only in the waters of Australia, Papua New Guinea, and Indonesia."
                    },
                    new Animal {
                        Id = 34,
                        Image = @"https://images.unsplash.com/photo-1701299762068-fa90e1234d45?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Blue Tang",
                        Species = "Fish",
                        Environment = ["Ocean", "Coral Reef"],
                        FoodPreference = "Omnivore",
                        Description = "Paracanthurus hepatus is a species of Indo-Pacific surgeonfish. A popular fish in marine aquaria, it is the only member of the genus Paracanthurus. A number of common names are attributed to the species, including regal tang, palette surgeonfish, blue tang (leading to confusion with the Atlantic species Acanthurus coeruleus), royal blue tang, hippo tang, blue hippo tang, flagtail surgeonfish, Pacific regal blue tang, and blue surgeonfish, hepatus tang, Indo-Pacific blue tang, regal blue surgeonfish, wedge-tailed tang, wedgetail blue tang. It is most closely related to genus Zebrasoma, with which it forms a sister group."
                    },
                    new Animal {
                        Id = 35,
                        Image = @"https://images.unsplash.com/photo-1706957782008-c26bd6c10840?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Hammerhead Shark",
                        Species = "Piscivore",
                        Environment = ["Ocean", "Coastal"],
                        FoodPreference = "Carnivore",
                        Description = "The hammerhead sharks are a group of sharks that form the family Sphyrnidae, named for the unusual and distinctive form of their heads, which are flattened and laterally extended into a cephalofoil (a T-shape or hammer). The shark's eyes are placed one on each end of this T-shaped structure, with their small mouths directly centered and underneath. Most hammerhead species are placed in the genus Sphyrna, while the winghead shark is placed in its own genus, Eusphyra. Many different—but not necessarily mutually exclusive—functions have been postulated for the cephalofoil, including sensory reception, manoeuvering, and prey manipulation. The cephalofoil gives the shark superior binocular vision and depth perception."
                    },
                    new Animal {
                        Id = 36,
                        Image = @"https://images.unsplash.com/photo-1584267814800-c9de7a2cfeac?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Anglerfish",
                        Species = "Piscivore",
                        Environment = ["Ocean", "Deep Ocean", "Atlantic", "Arctic"],
                        FoodPreference = "Herbivore",
                        Description = "The anglerfish are ray-finned fish in the order Lophiiformes. Both the order's common and scientific name comes from the characteristic mode of predation, in which a modified dorsal fin ray acts as a lure for prey (akin to a human angler, and likened to a crest or lophos). The modified fin ray, with the very tip being the esca and the length of the structure the illicium, is adapted to attract specific prey items across the families of anglerfish by using different luring methods."
                    },
                    new Animal {
                        Id = 37,
                        Image = @"https://images.unsplash.com/photo-1629055087005-6798b9f8658d?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Lobster",
                        Species = "Crustacean",
                        Environment = ["Ocean", "Coastal"],
                        FoodPreference = "Omnivore",
                        Description = "Lobsters are malacostracans decapod crustaceans of the family Nephropidae or its synonym Homaridae. They have long bodies with muscular tails and live in crevices or burrows on the sea floor. Three of their five pairs of legs have claws, including the first pair, which are usually much larger than the others. Highly prized as seafood, lobsters are economically important and are often one of the most profitable commodities in the coastal areas they populate."
                    },
                    new Animal {
                        Id = 38,
                        Image = @"https://images.unsplash.com/photo-1602264836619-094873fa05fc?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Orca",
                        Species = "Mammal",
                        Environment = ["Ocean", "Atlantic", "Pacific", "Arctic"],
                        FoodPreference = "Carnivore",
                        Description = "The orca (Orcinus orca), or killer whale, is a toothed whale and the largest member of the oceanic dolphin family. The only extant species in the genus Orcinus, it is recognizable by its black-and-white patterned body. A cosmopolitan species, it inhabits a wide range of marine environments, from Arctic to Antarctic regions to tropical seas."
                    },
                    new Animal {
                        Id = 39,
                        Image = @"https://images.unsplash.com/photo-1511828859793-8737beeff054?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Common Octopus",
                        Species = "Cephalopod",
                        Environment = ["Ocean", "Coastal"],
                        FoodPreference = "Piscivore",
                        Description = "The common octopus (Octopus vulgaris) is a mollusk belonging to the class Cephalopoda. Octopus vulgaris is one of the most studied of all octopus species, and also one of the most intelligent. It ranges from the eastern Atlantic, extends from the Mediterranean Sea, Black sea and the southern coast of England, to the southern coast of South Africa. It also occurs off the Azores, Canary Islands, and Cape Verde Islands. The species is also common in the Western Atlantic."
                    },
                    new Animal {
                        Id = 40,
                        Image = @"https://images.unsplash.com/photo-1597378609416-47cc937b294c?q=80&w=2080&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Sea Otter",
                        Species = "Mammal",
                        Environment = ["Ocean", "Coastal"],
                        FoodPreference = "Piscivore",
                        Description = "The sea otter (Enhydra lutris) is a marine mammal native to the coasts of the northern and eastern North Pacific Ocean. Adult sea otters typically weigh between 14 and 45 kg (30 and 100 lb), making them the heaviest members of the weasel family, but among the smallest marine mammals. Unlike most marine mammals, the sea otter's primary form of insulation is an exceptionally thick coat of fur, the densest in the animal kingdom. Although it can walk on land, the sea otter is capable of living exclusively in the ocean."
                    },
                    new Animal {
                        Id = 41,
                        Image = @"https://images.unsplash.com/photo-1603781194892-78a8e6f8b77f?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Moose",
                        Species = "Mammal",
                        Environment = ["Forest", "Arctic"],
                        FoodPreference = "Herbivore",
                        Description = "The moose (pl.: 'moose'; used in North America) or elk (pl.: 'elk' or 'elks'; used in Eurasia) (Alces alces) is the world's tallest, largest and heaviest extant species of deer and the only species in the genus Alces. It is also the tallest, and the second-largest, land animal in North America, falling short only of the American bison in body mass. Most adult male moose have broad, palmate (open-hand shaped) antlers; other members of the deer family have pointed antlers with a dendritic (twig-like) configuration. Moose inhabit the circumpolar boreal forests or temperate broadleaf and mixed forests of the Northern Hemisphere, thriving in cooler, temperate areas as well as subarctic climates."
                    },
                    new Animal {
                        Id = 42,
                        Image = @"https://images.unsplash.com/photo-1476922027627-aa7293e3aaa8?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Deer",
                        Species = "Mammal",
                        Environment = ["Forest", "Grasslands"],
                        FoodPreference = "Herbivore",
                        Description = "A deer (pl.: deer) or true deer is a hoofed ruminant ungulate of the family Cervidae (informally the deer family). Cervidae is divided into subfamilies Cervinae (which includes, among others, muntjac, elk (wapiti), red deer, and fallow deer) and Capreolinae (which includes, among others reindeer (caribou), white-tailed deer, roe deer, and moose). Male deer of almost all species (except the water deer), as well as female reindeer, grow and shed new antlers each year. These antlers are bony extensions of the skull and are often used for combat between males."
                    },
                    new Animal {
                        Id = 43,
                        Image = @"https://images.unsplash.com/photo-1530595467537-0b5996c41f2d?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Brown Bear",
                        Species = "Mammal",
                        Environment = ["Forest", "Mountain", "Caves"],
                        FoodPreference = "Omnivore",
                        Description = "The brown bear (Ursus arctos) is a large bear native to Eurasia and North America. Of the land carnivorans, it is rivaled in size only by its closest relative, the polar bear, which is much less variable in size and slightly bigger on average. The brown bear is a sexually dimorphic species, as adult males are larger and more compactly built than females. The fur ranges in color from cream to reddish to dark brown. It has evolved large hump muscles, unique among bears, and paws up to 21 cm (8.3 in) wide and 36 cm (14 in) long, to effectively dig through dirt. Its teeth are similar to those of other bears and reflect its dietary plasticity."
                    },
                    new Animal {
                        Id = 44,
                        Image = @"https://images.unsplash.com/photo-1724177457173-0817c44ae424?q=80&w=1935&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Northern Bat",
                        Species = "Mammal",
                        Environment = ["Forest", "Caves"],
                        FoodPreference = "Insectivores",
                        Description = "The northern bat is dark brown or black with some gold touched at the tip of the hairs in the head and back region. Its nose, ears, tail and wings are black or blackish brown. The coat on the ventral side is yellowish brown. It has short and rounded ears. It body length is 54 to 64 mm (2.1 to 2.5 in) with a wing span of 240 to 280 mm (9.4 to 11.0 in), and it weighs 8 to 16 g (0.28 to 0.56 oz) depending on the season."
                    },
                    new Animal {
                        Id = 45,
                        Image = @"https://images.unsplash.com/photo-1577382539866-5ef07a099858?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Wild Boar",
                        Species = "Mammal",
                        Environment = ["Forest", "Grasslands", "Wetlands", "Steppes"],
                        FoodPreference = "Herbivore",
                        Description = "The wild boar (Sus scrofa), also known as the wild swine, common wild pig, Eurasian wild pig, or simply wild pig, is a suid native to much of Eurasia and North Africa, and has been introduced to the Americas and Oceania. The species is now one of the widest-ranging mammals in the world, as well as the most widespread suiform. It has been assessed as least concern on the IUCN Red List due to its wide range, high numbers, and adaptability to a diversity of habitats. It has become an invasive species in part of its introduced range. Wild boars probably originated in Southeast Asia during the Early Pleistocene and outcompeted other suid species as they spread throughout the Old World."
                    },
                    new Animal {
                        Id = 46,
                        Image = @"https://images.unsplash.com/photo-1615018160530-d37d31520d87?q=80&w=1926&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Woodpecker",
                        Species = "Bird",
                        Environment = ["Forest", "Savanna",],
                        FoodPreference = "Insectivore",
                        Description = "Woodpeckers are part of the bird family Picidae, which also includes the piculets, wrynecks and sapsuckers. Members of this family are found worldwide, except for Australia, New Guinea, New Zealand, Madagascar and the extreme polar regions. Most species live in forests or woodland habitats, although a few species are known that live in treeless areas, such as rocky hillsides and deserts, and the Gila woodpecker specialises in exploiting cacti."
                    },
                    new Animal {
                        Id = 47,
                        Image = @"https://images.unsplash.com/photo-1607350999170-b893fef057ea?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Wolf",
                        Species = "Mammal",
                        Environment = ["Forest", "Tundra", "Grasslands"],
                        FoodPreference = "Carnivore",
                        Description = "The wolf (Canis lupus; pl.: wolves), also known as the grey wolf or gray wolf, is a canine native to Eurasia and North America. More than thirty subspecies of Canis lupus have been recognized, including the dog and dingo, though grey wolves, as popularly understood, only comprise naturally-occurring wild subspecies. The wolf is the largest wild extant member of the family Canidae, and is further distinguished from other Canis species by its less pointed ears and muzzle, as well as a shorter torso and a longer tail. The wolf is nonetheless related closely enough to smaller Canis species, such as the coyote and the golden jackal, to produce fertile hybrids with them. The wolf's fur is usually mottled white, brown, grey, and black, although subspecies in the arctic region may be nearly all white."
                    },
                    new Animal {
                        Id = 48,
                        Image = @"https://images.unsplash.com/photo-1641047258999-9c9bbcbf1aa2?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Viper",
                        Species = "Reptile",
                        Environment = ["Forest", "Wetlands", "Swamps"],
                        FoodPreference = "Omnivore",
                        Description = "Vipers are snakes in the family Viperidae, found in most parts of the world, except for Antarctica, Australia, Hawaii, Madagascar, New Zealand, Ireland, and various other isolated islands. They are venomous and have long (relative to non-vipers), hinged fangs that permit deep penetration and injection of their venom. Three subfamilies are currently recognized. They are also known as viperids. The name viper is derived from the Latin word vipera, -ae, also meaning viper, possibly from vivus (living) and parere (to beget), referring to the trait viviparity (giving live birth) common in vipers like most of the species of Boidae."
                    },
                    new Animal {
                        Id = 49,
                        Image = @"https://images.unsplash.com/photo-1590079015089-875baa76cc8d?q=80&w=1964&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Squirrel",
                        Species = "Mammal",
                        Environment = ["Forest"],
                        FoodPreference = "Herbivore",
                        Description = "Squirrels are members of the family Sciuridae, a family that includes small or medium-sized rodents. The squirrel family includes tree squirrels, ground squirrels (including chipmunks and prairie dogs, among others), and flying squirrels. Squirrels are indigenous to the Americas, Eurasia, and Africa, and were introduced by humans to Australia. The earliest known fossilized squirrels date from the Eocene epoch, and among other living rodent families, the squirrels are most closely related to the mountain beaver and dormice."
                    },
                    new Animal {
                        Id = 50,
                        Image = @"https://images.unsplash.com/photo-1667927028881-73a2c59e8bcd?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Lynx",
                        Species = "Mammal",
                        Environment = ["Forest", "Mountain"],
                        FoodPreference = "Carnivore",
                        Description = "A lynx links pl.: lynx or lynxes) is any of the four extant species (the Canada lynx, Iberian lynx, Eurasian lynx and the bobcat) within the medium-sized wild cat genus Lynx. The name originated in Middle English via Latin from the Greek word lynx (λύγξ), derived from the Indo-European root *leuk- ('light', 'brightness'), in reference to the luminescence of its reflective eyes."
                    },
                    new Animal {
                        Id = 51,
                        Image = @"https://images.unsplash.com/photo-1567784055803-b9d0a50d88e3?q=80&w=1933&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Manta Ray",
                        Species = "Mammal",
                        Environment = ["Coral Reef", "Ocean", "Coastal"],
                        FoodPreference = "Piscivore",
                        Description = "Manta rays are large rays belonging to the genus Mobula (formerly its own genus Manta). The larger species, M. birostris, reaches 7 m (23 ft) in width, while the smaller, M. alfredi, reaches 5.5 m (18 ft). Both have triangular pectoral fins, horn-shaped cephalic fins and large, forward-facing mouths. They are classified among the Myliobatiformes (stingrays and relatives) and are placed in the family Myliobatidae (eagle rays). They have the largest brain-to-body ratio of all fish, and can pass the mirror test."
                    },
                    new Animal {
                        Id = 52,
                        Image = @"https://images.unsplash.com/photo-1544552866-d3ed42536cfd?q=80&w=2071&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Clownfish",
                        Species = "Fish",
                        Environment = ["Coral Reef", "Ocean", "Lagoons"],
                        FoodPreference = "Omnivore",
                        Description = "Clownfish or anemonefish are saltwater fish from the subfamily Amphiprioninae in the family Pomacentridae. Thirty species of clownfish are recognized: one in the genus Premnas, while the remaining are in the genus Amphiprion. In the wild, they all form symbiotic mutualisms with sea anemones. Depending on the species, anemonefish are overall yellow, orange, or a reddish or blackish color, and many show white bars or patches. The largest can reach a length of 17 cm (6+1⁄2 in), while the smallest barely achieve 7–8 cm (2+3⁄4–3+1⁄4 in)."
                    },
                    new Animal {
                        Id = 53,
                        Image = @"https://images.unsplash.com/photo-1702872769303-54d80e668424?q=80&w=2071&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Butterflyfish",
                        Species = "Fish",
                        Environment = ["Coral Reef", "Ocean", "Oceanic"],
                        FoodPreference = "Piscivore",
                        Description = "The butterflyfish are a group of conspicuous tropical marine fish of the family Chaetodontidae; the bannerfish and coralfish are also included in this group. The approximately 129 species in 12 genera are found mostly on the reefs of the Atlantic, Indian, and Pacific Oceans. A number of species pairs occur in the Indian and Pacific Oceans, members of the huge genus Chaetodon."
                    },
                    new Animal {
                        Id = 54,
                        Image = @"https://images.unsplash.com/photo-1650978688025-c48862fde84a?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Giant Clam",
                        Species = "Mollusc",
                        Environment = ["Coral Reef", "Ocean"],
                        FoodPreference = "Filter Feeder",
                        Description = "Tridacna gigas, the giant clam, is the best-known species of the giant clam genus Tridacna. Giant clams are the largest living bivalve molluscs. Several other species of giant clam in the genus Tridacna are often misidentified as Tridacna gigas."
                    },
                    new Animal {
                        Id = 55,
                        Image = @"https://images.unsplash.com/photo-1703248187588-393e532ed0e4?q=80&w=1975&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Lionfish",
                        Species = "Fish",
                        Environment = ["Coral Reef", "Ocean"],
                        FoodPreference = "Piscivore",
                        Description = "Pterois is a genus of venomous marine fish, commonly known as the lionfish, native to the Indo-Pacific. It is characterized by conspicuous warning coloration with red or black bands and ostentatious dorsal fins tipped with venomous spines. Pterois radiata, Pterois volitans, and Pterois miles are the most commonly studied species in the genus. Pterois species are popular aquarium fish. P. volitans and P. miles are recent and significant invasive species in the west Atlantic, Caribbean Sea, and Mediterranean Sea."
                    },
                    new Animal {
                        Id = 56,
                        Image = @"https://images.unsplash.com/photo-1722583881397-b74fdc551cf7?q=80&w=1976&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Moon Jellyfish",
                        Species = "Scyphozoa",
                        Environment = ["Coral Reef", "Ocean", "Beaches"],
                        FoodPreference = "Omnivore",
                        Description = "Aurelia aurita (also called the common jellyfish, moon jellyfish, moon jelly or saucer jelly) is a species of the family Ulmaridae. All species in the genus are very similar, and it is difficult to identify Aurelia medusae without genetic sampling, most of what follows applies equally to all species of the genus."
                    },
                    new Animal {
                        Id = 57,
                        Image = @"https://images.unsplash.com/photo-1602401800685-c6b5bb197e9f?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Potato Grouper",
                        Species = "Fish",
                        Environment = ["Coral Reef", "Ocean", "Indian", "Pacific"],
                        FoodPreference = "Piscivore",
                        Description = "The potato grouper (Epinephelus tukula), also called the potato cod or potato bass, is a species of marine ray-finned fish, a grouper from the subfamily Epinephelinae which is part of the family Serranidae, which also includes the anthias and sea basses. It has a wide Indo-Pacific distribution."
                    },
                    new Animal {
                        Id = 58,
                        Image = @"https://images.unsplash.com/photo-1611362487572-2e5ac40c469d?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Leafy Sea Dragon",
                        Species = "Fish",
                        Environment = ["Coral Reef", "Ocean", "Rocky Reefs"],
                        FoodPreference = "Herbivore",
                        Description = "It is found along the southern and western coasts of Australia. The name is derived from their appearance, with long leaf-like protrusions coming from all over the body. These protrusions are not used for propulsion; they serve only as camouflage. The leafy seadragon propels itself utilising a pair of pectoral fins on the sides of its neck and a dorsal fin on its back closer to the tail end. These small fins are almost completely transparent and difficult to see as they undulate minutely to move the creature sedately through the water, completing the illusion of floating seaweed."
                    },
                    new Animal {
                        Id = 59,
                        Image = @"https://images.unsplash.com/photo-1548375044-6797a0c71799?q=80&w=2157&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Humphead Wrasse",
                        Species = "Fish",
                        Environment = ["Coral Reef", "Ocean", "Indian", "Pacific"],
                        FoodPreference = "Piscivore",
                        Description = "The humphead wrasse (Cheilinus undulatus) is a large species of wrasse mainly found on coral reefs in the Indo-Pacific region. It is also known as the Māori wrasse, Napoleon wrasse, Napoleon fish, so mei 蘇眉 (Cantonese), mameng (Filipino), and merer in the Pohnpeian language of the Caroline Islands."
                    },
                    new Animal {
                        Id = 60,
                        Image = @"https://images.unsplash.com/photo-1516683169270-7514e272a5fc?q=80&w=2072&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                        Name = "Moray Eel",
                        Species = "Fish",
                        Environment = ["Coral Reef", "Ocean"],
                        FoodPreference = "Carnivore",
                        Description = "Moray eels, or Muraenidae, are a family of eels whose members are found worldwide. There are approximately 200 species in 15 genera which are almost exclusively marine, but several species are regularly seen in brackish water, and a few are found in fresh water."
                    });
                _db.SaveChanges();
            }
        }
    }
}