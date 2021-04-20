using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCDinos.Data;
using MVCDinos.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new DinosaurContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<DinosaurContext>>()))
        {
            // Look for any classes already in the database.
            if (context.Classes.Any())
            {
                return;
            }

            // Add the classes
            context.Classes.AddRange(
                new Class
                {
                    ClassID = "A",
                    ClassName = "Ankylosauria",
                    ClassEasyName = "Armoured Dinosaurs",
                    ClassDesc = "Ankylosauria is the name given to a group of armoured dinosaurs (mostly herbivores), with short, powerful limbs."
                },

                new Class
                {
                    ClassID = "S",
                    ClassName = "Stegosauridae",
                    ClassEasyName = "Plated Dinosaurs",
                    ClassDesc = "This class of dinosaurs had bony spikes or plates, and were mostly slow and ate plants."
                },

                new Class
                {
                    ClassID = "T",
                    ClassName = "Theropoda",
                    ClassEasyName = "Meat-Eating Dinosaurs",
                    ClassDesc = "Therapoda is the name given to a group of meat-eating dinosaurs (although some also ate insects and plants."
                },

                new Class
                {
                    ClassID = "C",
                    ClassName = "Ceratopsia",
                    ClassEasyName = "Horned Dinosaurs",
                    ClassDesc = "These were a group of beaked dinosaurs, whose elabroate facial horns and frills extended over the neck."
                },

                new Class
                {
                    ClassID = "O",
                    ClassName = "Ornithopoda",
                    ClassEasyName = "Bird-Footed Dinosaurs",
                    ClassDesc = "This class of dinosaurs started out as bird-like grazers, later growing in size and numbers to become one of the most successful groups of herbivores in the Cretaceous world."
                }
            ); ;

            // Add the periods
            context.Periods.AddRange(
                new Period
                {
                    PeriodID = "ET",
                    PeriodName = "Early Triassic"
                },

                new Period
                {
                    PeriodID = "MT",
                    PeriodName = "Mid Triassic"
                },

                new Period
                {
                    PeriodID = "LT",
                    PeriodName = "Late Triassic"
                },

                new Period
                {
                    PeriodID = "EC",
                    PeriodName = "Early Cretaceous"
                },

                new Period
                {
                    PeriodID = "MC",
                    PeriodName = "Mid Cretaceous"
                },

                new Period
                {
                    PeriodID = "LC",
                    PeriodName = "Late Jurassic"
                },

                new Period
                {
                    PeriodID = "EJ",
                    PeriodName = "Early Jurassic"
                },

                new Period
                {
                    PeriodID = "MJ",
                    PeriodName = "Mid Jurassic"
                },

                new Period
                {
                    PeriodID = "LJ",
                    PeriodName = "Late Jurassic"
                }
            ); ;

            // Add the dinosaurs
            context.Dinosaurs.AddRange(
                new Dinosaur
                {
                    DinosaurName = "Nodosaurus",
                    BriefDesc = "Nodosaurus was one of the earliest armored dinosaurs discovered. This dinosaur was first identified by Othniel Charles Marsh who discovered remnants of it in 1889. In 1921, another scientist by the name of Richard Swann Lull further studied and described Nodosaurus. To this day, however, scientists have found little more than fragments of Nodosaurus bones.",
                    Pronounced = "Node-oh-sore-uss",
                    NameMeans = "Reptile with lumps",
                    ClassID = "A",
                    PeriodID = "MC",
                    LengthFt = 17,
                    WeightLbs = 5000,
                    LivedYearsAgo = 110000000
                },

                new Dinosaur
                {
                    DinosaurName = "Ankylosaurus",
                    BriefDesc = "Ankylosaurus is a very famous armored dinosaur. All other armored dinosaurs belong to the class Ankylosauria, which gets its name from this dinosaur. Ankylosaurus was one of the last armored dinosaurs to live, and indeed one of the last dinosaurs of any type to live.",
                    Pronounced = "Ann-kye-low-sore-uss",
                    NameMeans = "Fused Reptile",
                    ClassID = "A",
                    PeriodID = "LC",
                    LengthFt = 35,
                    WeightLbs = 8000,
                    LivedYearsAgo = 70000000
                },

                new Dinosaur
                {
                    DinosaurName = "Euoplocephalus",
                    BriefDesc = "Euoplocephalus was one of the most common dinosaurs to live in North America around 70 million years ago. Because they were so plentiful, their fossils have been found in a number of locations. These fossils show that Euoplocephalus was well protected. Even its eyelids had bony protrusions protecting the eyes. Euoplocephalus had spikes or horns on the side of its head and also running down its armored back. Its stiff tail ended with a hammer which it would have used to try and break the legs of enemies, such as Tyrannosaurus. Euoplocephalus was discovered and named in 1910 by Lawrence Lambe.",
                    Pronounced = "You-oh-ploe-seff-ah-luss",
                    NameMeans = "Well Protected Head",
                    ClassID = "A",
                    PeriodID = "LC",
                    LengthFt = 23,
                    WeightLbs = 4000,
                    LivedYearsAgo = 70000000
                },

                new Dinosaur
                {
                    DinosaurName = "Hylaeosaurus",
                    BriefDesc = "Hylaeosaurus is an important dinosaur in the history of dinosauria. This animal was first discovered in 1833 by Gideon Mantell. At this time, the term dinosaur had not yet been coined. In 1841, Richard Owen grouped Hylaeosaurus along with two other terrible lizards, calling them dinosaurs. Thus, Hylaeosaurus is one of the three original dinosaurs. Most of what we know about Hylaeosaurus comes from a fossil discovered in southern England.",
                    Pronounced = "High-lay-oh-sore-uss",
                    NameMeans = "Reptile of the Forest",
                    ClassID = "A",
                    PeriodID = "EC",
                    LengthFt = 17,
                    WeightLbs = 6000,
                    LivedYearsAgo = 115000000
                },

                new Dinosaur
                {
                    DinosaurName = "Pinacosaurus",
                    BriefDesc = "Pinacosaurus fossils were first discovered in the 1920s in the Gobi Desert by Roy Chapman Andrews. Many additional fossils of this animal have since been discovered. Often these fossil beds contain the remains of several individuals, suggesting that Pinacosaurus were social creatures living in groups. Some scientists believe that they lived in groups while young and then split up later in life to lead solitary lives. Pinacosaurus was armored, but was not as well protected as many of the other armored dinosaurs. This may have been due to less fierce predators where this animal thrived.",
                    Pronounced = "Pin-ah-coe-sore-uss",
                    NameMeans = "Plank Reptile",
                    ClassID = "A",
                    PeriodID = "LC",
                    LengthFt = 18,
                    WeightLbs = 3800,
                    LivedYearsAgo = 75000000
                },

                new Dinosaur
                {
                    DinosaurName = "Tenontosaurus",
                    BriefDesc = "Tenontosaurus was a medium-sized bird-footed, or ornithopod, dinosaur. Living in the early Cretaceous Period, this plant-eater spent its days crouched on all fours foraging for food, or standing on its rear legs trying to reach food high in the tree tops. Tenontosaurus probably spend most of its time walking bipedally on its rear legs, while using its front legs to grasp objects and also defend itself. Discovered in North America and named in 1970 by John Ostrom.",
                    Pronounced = "'Ten-on-toe-sore-uss",
                    NameMeans = "Sinew Lizard",
                    ClassID = "O",
                    PeriodID = "EC",
                    LengthFt = 25,
                    WeightLbs = 2000,
                    LivedYearsAgo = 140000000
                },

                new Dinosaur
                {
                    DinosaurName = "Altirhinus",
                    BriefDesc = "Altirhinus is a typical iguanodontid. In fact, in 1952 it was originally named Iguanodon Orientalis. Scientists believed that it was in fact a sub-species of Iguanadon. As time went on, it became apparent that this dinosaur was actually a separate species. In 1998 it was renamed Altirhinus. Altirhinus was a member of the Ornithopoda, or bird-foot group. These dinosaurs had feet similar to those of modern birds. In many ways this dinosaur resembled a camel.",
                    Pronounced = "All-tee-ryne-uss",
                    NameMeans = "High Snout",
                    ClassID = "O",
                    PeriodID = "EC",
                    LengthFt = 26,
                    WeightLbs = 8000,
                    LivedYearsAgo = 150000000
                },

                new Dinosaur
                {
                    DinosaurName = "Panoplosaurus",
                    BriefDesc = "First discovered in 1917 by Lawrence Lambe in Alberta, Canada, Panoplosaurus is one of the best known of all armored dinosaurs. This is because of the completeness of fossils, including an almost completely intact skull.",
                    Pronounced = "Pan-oh-ploh-sore-uss",
                    NameMeans = "Completely Covered In Armour",
                    ClassID = "A",
                    PeriodID = "LC",
                    LengthFt = 23,
                    WeightLbs = 7500,
                    LivedYearsAgo = 75000000
                },

                new Dinosaur
                {
                    DinosaurName = "Hypsilophodon",
                    BriefDesc = "Hypsilophodon roamed the Earth during the Early Cretaceous Period, and is considered to have belonged to the Ornithopoda, or bird-footed group. The name Hypsilophodon comes from the shape of its teeth, which allowed it to grind up its food prior to swallowing it. This smaller dinosaur is one of very few reptiles to have had cheeks. A feature that allowed it to keep food stored in its mouth while it chewed, similar to how humans chew food today. Hypsilophodon was discovered in 1869 by Gideon Mantall.",
                    Pronounced = "Hip-sill-owe-foe-don",
                    NameMeans = "High-Ridged Teeth",
                    ClassID = "O",
                    PeriodID = "EC",
                    LengthFt = 8,
                    WeightLbs = 88,
                    LivedYearsAgo = 140000000
                },

                new Dinosaur
                {
                    DinosaurName = "Tenontosaurus",
                    BriefDesc = "Tenontosaurus was a medium-sized bird-footed, or ornithopod, dinosaur. Living in the early Cretaceous Period, this plant-eater spent its days crouched on all fours foraging for food, or standing on its rear legs trying to reach food high in the tree tops. Tenontosaurus probably spend most of its time walking bipedally on its rear legs, while using its front legs to grasp objects and also defend itself. Discovered in North America and named in 1970 by John Ostrom.",
                    Pronounced = "'Ten-on-toe-sore-uss",
                    NameMeans = "Sinew Lizard",
                    ClassID = "O",
                    PeriodID = "EC",
                    LengthFt = 25,
                    WeightLbs = 2000,
                    LivedYearsAgo = 140000000
                },

                new Dinosaur
                {
                    DinosaurName = "Altirhinus",
                    BriefDesc = "Altirhinus is a typical iguanodontid. In fact, in 1952 it was originally named Iguanodon Orientalis. Scientists believed that it was in fact a sub-species of Iguanadon. As time went on, it became apparent that this dinosaur was actually a separate species. In 1998 it was renamed Altirhinus. Altirhinus was a member of the Ornithopoda, or bird-foot group. These dinosaurs had feet similar to those of modern birds. In many ways this dinosaur resembled a camel.",
                    Pronounced = "All-tee-ryne-uss",
                    NameMeans = "High Snout",
                    ClassID = "O",
                    PeriodID = "EC",
                    LengthFt = 26,
                    WeightLbs = 8000,
                    LivedYearsAgo = 150000000
                },

                new Dinosaur
                {
                    DinosaurName = "Panoplosaurus",
                    BriefDesc = "First discovered in 1917 by Lawrence Lambe in Alberta, Canada, Panoplosaurus is one of the best known of all armored dinosaurs. This is because of the completeness of fossils, including an almost completely intact skull.",
                    Pronounced = "Pan-oh-ploh-sore-uss",
                    NameMeans = "Completely Covered In Armour",
                    ClassID = "A",
                    PeriodID = "LC",
                    LengthFt = 23,
                    WeightLbs = 7500,
                    LivedYearsAgo = 75000000
                },

                new Dinosaur
                {
                    DinosaurName = "Hypsilophodon",
                    BriefDesc = "Hypsilophodon roamed the Earth during the Early Cretaceous Period, and is considered to have belonged to the Ornithopoda, or bird-footed group. The name Hypsilophodon comes from the shape of its teeth, which allowed it to grind up its food prior to swallowing it. This smaller dinosaur is one of very few reptiles to have had cheeks. A feature that allowed it to keep food stored in its mouth while it chewed, similar to how humans chew food today. Hypsilophodon was discovered in 1869 by Gideon Mantall.",
                    Pronounced = "Hip-sill-owe-foe-don",
                    NameMeans = "High-Ridged Teeth",
                    ClassID = "O",
                    PeriodID = "EC",
                    LengthFt = 8,
                    WeightLbs = 88,
                    LivedYearsAgo = 140000000
                },

                new Dinosaur
                {
                    DinosaurName = "Muttaburrasaurus",
                    BriefDesc = "Other than its curved, beak-like mouth, Muttaburrasaurus was a typical iguanodontid. It used its unique mouth to scoop plant material up off the ground and low lying plants. It then used flat teeth located in its cheeks to chew the plant material before swallowing. It is believed that Muttaburrasaurus probably walked on its hind legs, using its tail to balance This would have left its long forearms free for feeding itself. Muttaburrasaurus was discovered in Australia in 1963.",
                    Pronounced = "Mutt-ah-burr-ah-sore-uss",
                    NameMeans = "Muttaburra Lizard",
                    ClassID = "O",
                    PeriodID = "MC",
                    LengthFt = 21,
                    WeightLbs = 6000,
                    LivedYearsAgo = 100000000
                },

                new Dinosaur
                {
                    DinosaurName = "Dryosaurus",
                    BriefDesc = "Dryosaurus was discovered and named by the world famous paleontologist Othniel Charles Marsh. Living during the Late Jurassic period, Dryosaurus is one of the first Ornithopods to have evolved. Ornithopod means bird-footed dinosaur, which refers to the fact that the hind feet of this dinosaurs was very similar to those of modern birds. Many scientists today believe that birds actually evolved from dinosaurs. Another feature that Dryosaurus had in common with modern birds was its beak. It used this beak to cut vegetation.",
                    Pronounced = "Dry-owe-sore-uss",
                    NameMeans = "Tree Lizard",
                    ClassID = "O",
                    PeriodID = "LJ",
                    LengthFt = 10,
                    WeightLbs = 70,
                    LivedYearsAgo = 145000000
                },

                new Dinosaur
                {
                    DinosaurName = "Lesothosaurus",
                    BriefDesc = "A tiny cat-sized dinosaur by the name of Lesothosaurus lived around 210 million years ago in Africa and South America. Some paleontologists, or dinosaur experts, believe that Lesothosaurus was the ancestor of many later bird-footed dinosaurs such as Iguanodon. A bird-footed dinosaur is a dinosaur with hind-legs that resemble those of modern day birds. Many scientists believe that birds actually evolved from dinosaurs. Lesothosaurus had long hind legs, and short, stubby front arm-like legs.",
                    Pronounced = "Le-soe-toe-sore-uss",
                    NameMeans = "Lesotho Lizard",
                    ClassID = "O",
                    PeriodID = "EJ",
                    LengthFt = 3,
                    WeightLbs = 8,
                    LivedYearsAgo = 205000000
                },

                new Dinosaur
                {
                    DinosaurName = "Stegosaurus",
                    BriefDesc = "One of the most famous of all the dinosaurs, Stegosaurus lived around 150 million years ago. Because of its tiny head and brain, many consider Stegosaurus and other plated dinosaurs to have been the least intelligent of all the dinosaurs. Stegosaurus was the largest of the Stegosauridae, or plated dinosaurs. It was just a little larger than a modern day elephant, and had a line of bony plates running down its back.",
                    Pronounced = "Steg-owe-sore-uss",
                    NameMeans = "Roofed Reptile",
                    ClassID = "S",
                    PeriodID = "LJ",
                    LengthFt = 29,
                    WeightLbs = 6000,
                    LivedYearsAgo = 150000000
                },

                new Dinosaur
                {
                    DinosaurName = "Dravidosaurus",
                    BriefDesc = "There is much controversy today among scientists regarding Dravidosaurus. Many believe that Dravidosaurus was a stegosaurid living in India. Others suggest that Dravidosaurus was not a dinosaur at all. They believe that the fossils have been reconstructed incorrectly, and that Dravidosaurus is actually a swimming reptile.",
                    Pronounced = "Drav-id-oh-sore-uss",
                    NameMeans = "Reptile From Dravidanadu",
                    ClassID = "S",
                    PeriodID = "LC",
                    LengthFt = 10,
                    WeightLbs = 750,
                    LivedYearsAgo = 138000000
                },


                new Dinosaur
                {
                    DinosaurName = "Velociraptor",
                    BriefDesc = "Velociraptor is probably one of the most famous dinosaurs that has ever lived. It achieved this fame because of a movie in the early 1990s titled Jurassic Park. In this movie, Velociraptors size was increased to make it seem more scary. At the time, Velociraptors larger cousin, Utahraptor, had not yet been discovered.",
                    Pronounced = "Vell-oss-ee-rap-tore",
                    NameMeans = "Quick Hunter",
                    ClassID = "T",
                    PeriodID = "LC",
                    LengthFt = 6,
                    WeightLbs = 65,
                    LivedYearsAgo = 80000000
                },

                new Dinosaur
                {
                    DinosaurName = "Oviraptor",
                    BriefDesc = "There is much dispute about Oviraptor and its lifestyle and eating habits. It was first discovered and named in 1923. The skeleton was found among eggs, and looked as though it might have died while raiding the nest. The name Oviraptor means egg hunter. However, many scientists believe that Oviraptor was actually protecting its own nest, and not eating the eggs.",
                    Pronounced = "Owe-vee-rap-tore",
                    NameMeans = "Egg Hunter",
                    ClassID = "T",
                    PeriodID = "LC",
                    LengthFt = 7,
                    WeightLbs = 75,
                    LivedYearsAgo = 70000000
                },

                new Dinosaur
                {
                    DinosaurName = "Tyrannosaurus Rex",
                    BriefDesc = "The king of the dinosaurs, and certainly the most famous. Tyrannosaurus Rex has lived in the imaginations of children and adults for decades. Staring in many films, books and television shows, Tyrannosaurus was certainly a terrifying hunter. For almost 90 years, T-Rex was the largest known predator to have ever walked on the Earth.",
                    Pronounced = "Tie-ran-owe-sore-uss",
                    NameMeans = "Tyrant Reptile",
                    ClassID = "T",
                    PeriodID = "LC",
                    LengthFt = 40,
                    WeightLbs = 12000,
                    LivedYearsAgo = 65000000
                },

                new Dinosaur
                {
                    DinosaurName = "Triceratops",
                    BriefDesc = "Triceratops is today one of the most famous of all the dinosaurs. This large Ceratopsia, or horned dinosaur, lived up until the very end of the dinosaur age around 65 million years ago. Like other horned dinosaurs, Triceratops had a large ridge that ran around the back of its skull. The use of this ridge is still debated today. Many believe that it may have been used to make the animal look larger and more dangerous, or that perhaps it was used to anchor powerful jaw muscles to the skull. Triceratops probably used its powerful beak to crush food, such as vegetation.",
                    Pronounced = "Try-serra-tops",
                    NameMeans = "Three Horned Head",
                    ClassID = "C",
                    PeriodID = "LC",
                    LengthFt = 30,
                    WeightLbs = 12000,
                    LivedYearsAgo = 65000000
                },

                new Dinosaur
                {
                    DinosaurName = "Microceratops",
                    BriefDesc = "Microceratops is the smallest known ceratops, or horned dinosaur. It lived around 70 million years ago in Asia. Microceratops was discovered in 1953 in Mongolia. Subsequently, additional fossils have been found in Mongolia and also in China. Microceratops was both small and lightly built. This probably made Microceratops very agile and fast. Microceratops'' back legs were longer than its front legs, allowing it to balance and hop on the hind legs when needed. Microceratops did not have any horns, but it did have the obvious head frill so common with horned dinosaurs.",
                    Pronounced = "My-croe-serra-tops",
                    NameMeans = "Tiny Horned-Face",
                    ClassID = "C",
                    PeriodID = "LC",
                    LengthFt = 3,
                    WeightLbs = 22,
                    LivedYearsAgo = 65000000
                },

                new Dinosaur
                {
                    DinosaurName = "Bagaceratops",
                    BriefDesc = "Bagaceratops was discovered in Omnogov, Mongolia, in 1975 by Teresa Maryanska and Halszka Osmolska. This dinosaur gets its name from its size. Bagaceratops was only about 1 meter in length, or roughly the size of a modern day rabbit, although Bagaceratops would have been more heavily built. Bagaceratops had a small horn on its snout as well as a small neck frill. Its hind legs were longer than its front legs. Bagaceratops had a sharp beak resembling the beak of a modern day parrot.",
                    Pronounced = "Bag-ah-serra-tops",
                    NameMeans = "Small-Horned Dinosaur",
                    ClassID = "C",
                    PeriodID = "LC",
                    LengthFt = 35,
                    WeightLbs = 65,
                    LivedYearsAgo = 70000000
                },

                new Dinosaur
                {
                    DinosaurName = "Craterosaurus",
                    BriefDesc = "A single fossil exists from Craterosaurus which was found in Bedfordshire, England, in 1874. This fossil is a vertebra from Craterosaurus'' back. Everything we know about Craterosaurus is based on this single fossil, and by comparing it to other plated dinosaurs of the time. Craterosaurus is believed to have been a small stegosaurid.",
                    Pronounced = "Kray-ter-oh-sore-uss",
                    NameMeans = "Crater Reptile",
                    ClassID = "S",
                    PeriodID = "EC",
                    LengthFt = 13,
                    WeightLbs = 1100,
                    LivedYearsAgo = 137000000
                },


                new Dinosaur
                {
                    DinosaurName = "Kentrosaurus",
                    BriefDesc = "Living around 150 million years ago in Africa, Kentrosaurus is often considered to have been the close cousin of Stegosaurus. Like Stegosaurus, Kentrosaurus had plates attached to its back. However, unlike Stegosaurus, these plates gradually became narrower as they ran down its body until they were more like spikes. Like other members of the Stegosauridae, or plated dinosaur group, Kentrosaurus had a very small brain.",
                    Pronounced = "Ken-troe-sore-uss",
                    NameMeans = "Spiked Reptile",
                    ClassID = "S",
                    PeriodID = "LJ",
                    LengthFt = 17,
                    WeightLbs = 4000,
                    LivedYearsAgo = 150000000
                },


                new Dinosaur
                {
                    DinosaurName = "Paranthodon",
                    BriefDesc = "Paranthodon was one of the very first dinosaurs to be discovered in Africa. This dinosaur was first discovered in 1845 by Andrew Bain and William Atherstone. Andrew Bain found the fossil while helping to construct a new road. He thought that it looked reptilian and sent it to London to be examined by Richard Owen. The fossil consisted of a partial skull. Owen combined the skull with some other fossils that had been found earlier, and named the animal Anthodon. Later it was discovered that the fossils that had been combined with the skull were actually from another animal. Thus, they were taken away, and the dinosaur was renamed Paranthodon.",
                    Pronounced = "Parr-ann-thoe-don",
                    NameMeans = "Besides Anthodon",
                    ClassID = "S",
                    PeriodID = "EC",
                    LengthFt = 16,
                    WeightLbs = 2000,
                    LivedYearsAgo = 125000000
                },


                new Dinosaur
                {
                    DinosaurName = "Chasmosaurus",
                    BriefDesc = "Chasmosaurus was discovered and named in 1914 by Lawrence Lambe. The name Chasmosaurus means Ravine Reptile, and comes from the fact that " +
                    "its neck frill had depressions that resemble the ravines found on the countryside. Chasmosaurus was a medium size ceratopsian, or horned dinosaur. " +
                    "This dinosaur was different from other ceratopsians because it had two eyebrow horns that were longer than the horn on its snout.",
                    Pronounced = "Kaz-moe-sore-uss",
                    NameMeans = "Reptile From The Ravine",
                    ClassID = "C",
                    PeriodID = "LC",
                    LengthFt = 19,
                    WeightLbs = 6600,
                    LivedYearsAgo = 73000000
                },

                new Dinosaur
                {
                    DinosaurName = "Camptosaurus",
                    BriefDesc = "Camptosaurus was first discovered in 1879 by paleontologist Earl Douglass. That same year, this new dinosaur was given the name Camptonotus by Othniel Charles Marsh. It was later renamed in 1885 by Marsh because its original name already belonged to a type of cricket. This dinosaur was a typical Iguanidontid, spending its days moving from place to place looking for plant material to devour. Using its tail as a counter-weight, Camptosaurus was able to balance on its hind-legs, leaving its arms for feeding and other tasks, such as self-defense. Fossilized tracks show evidence that Camptosaurus also walked on all fours at times.",
                    Pronounced = "Kamp-toe-sore-uss",
                    NameMeans = "Flexible Lizard",
                    ClassID = "O",
                    PeriodID = "LJ",
                    LengthFt = 19,
                    WeightLbs = 4000,
                    LivedYearsAgo = 90000000
                },


                new Dinosaur
                {
                    DinosaurName = "Monoclonius",
                    BriefDesc = "Monoclonius was discovered by Edward Drinker Cope in 1876 in North America. This horned dinosaur had one large horn just above its nose, and also likely had two smaller down-turned horns near the top of its head frill. Like other horned dinosaurs, Monoclonius had a beak-like mouth. This mouth was filled with a single row of teeth. Monoclonius spent its life foraging for food, and avoiding the large predators that roamed North America during this time period.",
                    Pronounced = "Mon-owe-clone-ee-uss",
                    NameMeans = "One Horn",
                    ClassID = "D",
                    PeriodID = "LC",
                    LengthFt = 20,
                    WeightLbs = 7500,
                    LivedYearsAgo = 68000000
                },


                new Dinosaur
                {
                    DinosaurName = "Pachyrhinosaurus",
                    BriefDesc = "This medium size horned dinosaur was discovered and named in 1951 by Charles M. Sternberg. Hundreds of individuals from this species have been found in multiple locations. It is believed that Pachyrhinosaurus probably migrated in large herds. Like other horned dinosaurs, Pachyrhinosaurus had a large neck frill, a parrot-like beak, and horns on its head.",
                    Pronounced = "Pack-ee-rhine-owe-sore-uss",
                    NameMeans = "Thick-Nosed Reptile",
                    ClassID = "C",
                    PeriodID = "LC",
                    LengthFt = 20,
                    WeightLbs = 750,
                    LivedYearsAgo = 70000000
                },

                new Dinosaur
                {
                    DinosaurName = "Eoraptor",
                    BriefDesc = "Eoraptor is one of the earliest known dinosaurs. This creature was discovered in 1991 by a group of students doing research in Argentina, and was named by Paul Sereno. Eoraptor was a lightweight predator with hollow bones, much like modern day birds. Its teeth were suited for eating small animals such as lizards and worms. Although smaller, this small predator dinosaur was constructed much like later predator dinosaurs, with small forelegs and large hind legs, allowing it to walk and run bipedally.",
                    Pronounced = "Ee-owe-rap-tore",
                    NameMeans = "Dawn Hunter",
                    ClassID = "T",
                    PeriodID = "MT",
                    LengthFt = 3,
                    WeightLbs = 21,
                    LivedYearsAgo = 228000000
                },



                new Dinosaur
                {
                    DinosaurName = "Iguanadon",
                    BriefDesc = "Iguanodon is one of the most popular and most well known of all the dinosaurs. Living on the " +
                    "Earth for tens of millions of years, Iguanodon was also one of the most successful dinosaurs. Iguanodon was " +
                    "discovered and named in 1825 by Gideon Mantell. Mantell named the animal Iguanodon, which means iguana - " +
                    "like teeth, because the fossils he found were teeth that looked like those of a modern day iguana. Mantell thought they probably belonged to a long extinct lizard.",
                    Pronounced = "Ig-wan-oh-don",
                    NameMeans = "Iguana Teeth",
                    ClassID = "O",
                    PeriodID = "EC",
                    LengthFt = 33,
                    WeightLbs = 9000,
                    LivedYearsAgo = 150000000
                },

                new Dinosaur
                {
                    DinosaurName = "Coelophysis",
                    BriefDesc = "In 1940, thousands of Coelophysis bones were discovered in a small area. These animals probably all died together, perhaps in a flash flood or other natural disaster. Coelophysis'' light-weight body and long neck made it an excellent hunter. This predator was a quick and agile creature, able to dart from side to side as it chased its prey or escaped from its enemies. Coelophysis shares many features with early birds, including hollow bones and a beak-like mouth.",
                    Pronounced = "See-low-fye-siss",
                    NameMeans = "Hollow Shape",
                    ClassID = "T",
                    PeriodID = "LT",
                    LengthFt = 10,
                    WeightLbs = 77,
                    LivedYearsAgo = 220000000
                },



                new Dinosaur
                {
                    DinosaurName = "Segisaurus",
                    BriefDesc = "Only a few bones of this early dinosaur have been discovered. From what has been discovered, it is believed that Segisaurus was a meat-eating Theropod. Segisaurus was probably a fast sprinter, able to dart from side to side as it hunted its prey.",
                    Pronounced = "Say-ee-sore-uss",
                    NameMeans = "Reptile of Segi",
                    ClassID = "T",
                    PeriodID = "LT",
                    LengthFt = 10,
                    WeightLbs = 77,
                    LivedYearsAgo = 200000000
                },



                new Dinosaur
                {
                    DinosaurName = "Staurikosaurus",
                    BriefDesc = "Staurikosaurus is one of the earliest known dinosaurs. This ancient predator was discovered in what is now modern day Brazil. Like other Theropods, Staurikosaurus had evolved to walk and run on its hind legs (bipedally). This man size animal probably hunted smaller animals as well as young animals and possibly eggs.",
                    Pronounced = "Store-ick-owe-sore-uss",
                    NameMeans = "Southern Cross Reptile",
                    ClassID = "T",
                    PeriodID = "LT",
                    LengthFt = 7,
                    WeightLbs = 33,
                    LivedYearsAgo = 220000000
                },



                new Dinosaur
                {
                    DinosaurName = "Avimimus",
                    BriefDesc = "Avimimus was discovered and named in the late 1970s. At the time of its discovery, a few thought that it had feathers. However, at that time, this was a radical notion. Today, evidence of feathered dinosaurs is much more clear and strong. Whether feathered or not, Avimimus was a swift runner and hunter, able to scoop up small prey, and crush it in its beak.",
                    Pronounced = "Aye-vee-mim-uss",
                    NameMeans = "Bird Mimic",
                    ClassID = "T",
                    PeriodID = "LC",
                    LengthFt = 6,
                    WeightLbs = 35,
                    LivedYearsAgo = 75000000
                },

                new Dinosaur
                {
                    DinosaurName = "Utahraptor",
                    BriefDesc = "The Utah Raptor, a skilled and powerful hunter, was discovered in central Utah, North America, in 1993. This dinosaur is one of the largest and most powerful Raptors to have yet been identified. Utahraptor used its sharp, sickle-like claw to slash and rip apart larger plant-eating animals. It also used its long sharp teeth to bite and tear its victims. It is believed by many scientists that Utahraptor was a warm-blooded animal. Fossil evidence shows that the inside of Utahraptor''s bones was more like a modern day mammal than like that of a cold-blooded animal. This would have given Utahraptor a huge advantage over its prey. The large cold-blooded, plant-eating dinosaurs would have been very slow each morning as they waited for the sunlight to heat their bodies to a point where they could move more quickly. This would have been the perfect time for Utahraptor to attack. If it was warm-blooded, Utahraptor would have been fast moving no matter what the temperature outside.",
                    Pronounced = "You-taw-rap-tore",
                    NameMeans = "Hunter of Utah",
                    ClassID = "T",
                    PeriodID = "EC",
                    LengthFt = 18,
                    WeightLbs = 1100,
                    LivedYearsAgo = 120000000
                },


                new Dinosaur
                {
                    DinosaurName = "Theizinosaurus",
                    BriefDesc = "Theizinosaurus is one of the strangest dinosaurs to have ever lived. It is a decendent of the meat-eating dinosaurs known as Theropods, but it probably did not eat meat. Instead, Theizinosaurus used its long claws to rake vegetation into its mouth. Theizinosaurus had strong hind legs and shorter, weaker arms. The claws of Theizinosaurus were as long as a human arm.",
                    Pronounced = "There-iz-in-owe-sore-uss",
                    NameMeans = "Scythe Reptile",
                    ClassID = "T",
                    PeriodID = "LC",
                    LengthFt = 33,
                    WeightLbs = 2000,
                    LivedYearsAgo = 75000000
                },


                new Dinosaur
                {
                    DinosaurName = "Coelurus",
                    BriefDesc = "Little is known about Coelurus. This small meat-eater, or carnivore, was discovered by Othniel Charles Marsh in Wyoming, North America, around 1879. Coelurus was about the same height as a full grown man. This might seem big, but in dinosaur terms, this was a small creature indeed. It is possible that Coelurus was a direct ancestor of the most famous dinosaur of all: T-Rex.",
                    Pronounced = "Seel-yur-uss",
                    NameMeans = "Hollow Tail",
                    ClassID = "T",
                    PeriodID = "LJ",
                    LengthFt = 7,
                    WeightLbs = 23,
                    LivedYearsAgo = 150000000
                },


                new Dinosaur
                {
                    DinosaurName = "Ornitholestes",
                    BriefDesc = "This small predatory dinosaur lived around 150 million years ago. The name Ornitholestes means ''bird-robber''. It is thought that Ornitholestes raided the nests of early birds in search of a meal. Ornitholestes was likely a swift runner and an excellent hunter. In addition to eggs, Ornitholestes probably ate small and medium-sized animals. Ornitholestes had a unique ridge along the end of its snout which may have been used to attract a mate.",
                    Pronounced = "Or-nith-owe-less-teez",
                    NameMeans = "Robber of Birds",
                    ClassID = "T",
                    PeriodID = "LJ",
                    LengthFt = 8,
                    WeightLbs = 33,
                    LivedYearsAgo = 150000000
                },


                new Dinosaur
                {
                    DinosaurName = "Troodon",
                    BriefDesc = "Troodon, discovered and named in 1856, was a small, fast hunter. This dinosaur probably ate small animals such as early mammals, frogs, birds and smaller reptiles. While not a very large theropod, it is believed that Troodon was one of the most intelligent dinosaurs to have ever lived. Many scientists believe that Troodon was covered in feathers. This leads them to believe that modern day birds could have descended from dinosaurs.",
                    Pronounced = "Troe-owe-don",
                    NameMeans = "Wounding Tooth",
                    ClassID = "T",
                    PeriodID = "LC",
                    LengthFt = 8,
                    WeightLbs = 33,
                    LivedYearsAgo = 70000000
                },

                new Dinosaur
                {
                    DinosaurName = "Deinonychus",
                    BriefDesc = "Deinonychus is a widely debated animal among scientists. Some believe that this ferocious killer was both warm-blooded and possibly very intelligent. Deinonychus'' skull suggests that it had a large brain, and was possibly cabable of learned behaviors. Evidence suggests that Deinonychus may have hunted large plant-eating dinosaurs, taking them down by leaping on their backs in packs, similar to how a modern day pack of wolves takes down a large moose. Deinonychus and its descendants appear to have been quick, agile animals, capable of jumping great distances.",
                    Pronounced = "Die-non-ee-kuss",
                    NameMeans = "Terrible Claw",
                    ClassID = "T",
                    PeriodID = "MC",
                    LengthFt = 10,
                    WeightLbs = 130,
                    LivedYearsAgo = 100000000
                }

            ); ;


            context.SaveChanges();
        }
    }
}