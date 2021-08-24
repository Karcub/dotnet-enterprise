using System;

namespace dotnet_enterprise.Models
{
    public class EventInitializer
    {
        public EventItem[] EventItems { get; }
        
        
        public EventInitializer()
        {
            EventItem eventItem = new EventItem
            {
                Id = 1,
                Name = "Semmi",
                IsFavorite = false,
                Description = "<p><em>Az előadás a Nordiska Aps International Performing Rights Agency és a Proscenium Szerzői Ügynökség engedélyével jött létre.</em></p>" +
                              "<p>„Semminek sincs értelme, ezt régóta tudom. Ezért semmit sem érdemes csinálni. Erre most jöttem rá” – mondja a nyolcadikos Pierre Anthon," +
                              " majd kisétál az osztályteremből, felül egy szilvafára, hogy onnan kiáltsa világgá az élet hiábavalóságát. Osztálytársai elhatározzák, hogy" +
                              " bebizonyítják neki az ellenkezőjét, ezért tárgyakat kezdenek gyűjteni, „fontos dolgokat”, amelyekért érdemes élni. Egy bicikli," +
                              " amelyre évekig spórolt a tulajdonosa, egy napló, egy lány hosszú haja... A játéknak induló bizonyítás azonban hamarosan kontrollálhatatlanná válik." +
                              " Mindenki sebezhető lesz, mindenkitől elveszik, ami a legfontosabb neki, miközben a „Fontos Dolgok Halma” egyre nő, és lassan mindent bekebelez." +
                              " Janne Teller világhírű ifjúsági regénye olyan könyv, amely nem fél kérdezni.</p><p>A Semmi az Semmi. Útkeresés, kétségbeesés, próbálkozás," +
                              " félsiker, kilátástalanság, problémamegoldás, kontrollvesztés. Mindez egy kiváló színészzenekarra hangszerelve, ahol mindenki játszik, hol hangszeren," +
                              " hol bábon, hol anélkül. Ahol mindenki elveszít valamit, valamit meg talán nyer.</p><p><em>Hoffer Károly rendező</em></p>" +
                              "<p>Csoportok számára Mozgató program is elérhető.</p>",
                City = "Budapest",
                Location = "Budapest Bábszínház, Ország Lili Stúdió<br>1062 Budapest, Andrássy út 69.",
                Image = "https://pb2.jegy.hu/imgs/system-4/program/000/040/179/semmi-474-279-37355.jpg",
                EventUrl = "https://www.jegy.hu/program/semmi-40179",
                UserId = 1,
                Date = new DateTime(2021, 9, 29, 13, 00,00),
                Category = "THEATHER"
            };
            EventItem eventItem2 = new EventItem
            {
                Id = 2,
                Name = "Giselle",
                IsFavorite = false,
                Description = "<p>Az 1841-ben bemutatott Giselle talán az egyetlen romantikus balett, amelyet a világ minden jelentős balettszínpadán még ma is játszanak." +
                              " A balett témája egy német mondából származik: a villik esküvőjük előtt meghalt menyasszonyok, akik éjfélkor kikelnek sírjukból és kísértetként" +
                              " lebegnek a holdsütötte völgyekben, és jaj annak, akit sikerül táncba csalniuk! Irgalmatlanul halálra táncoltatják!" +
                              " 'Ami titokzatos és távoli, földöntúli, mindaz intim és termékeny viszonyba került a balettel' - mondta Théophile Gautier." +
                              " A meseszerű történet a szerelmi csalódásába belehalt Giselle földöntúli létezésén át jeleníti meg a férfi és a nő között feszülő érzelmeket:" +
                              " a balettirodalom egyik legösszetettebb és legnehezebb főszerepe ez. Minden táncossal szemben komoly technikai követelményeket támaszt a mű:" +
                              " Giselle légiességét, a férfi szereplők szenvedélyességét, a villik pihekönnyű mozdulatait csak a klasszikus balett legjobbjai képesek hitelesen" +
                              " visszaadni.<br><br>A mű az orosz koreográfus-legenda, Leonyid Lavrovszkij híres átdolgozásában, az ún. moszkvai változatban látható a Magyar" +
                              " Nemzeti Balett művészeinek tolmácsolásában.</p>",
                City = "Budapest",
                Location = "Erkel Színház / Erkel Theatre, Erkel Színház<br>1087 Budapest, II. János Pál pápa tér 30.",
                Image = "https://pb2.jegy.hu/imgs/system-4/program/000/090/843/giselle-474-279-139792.jpg",
                EventUrl = "https://www.jegy.hu/program/giselle-90843",
                UserId = 1,
                Date = new DateTime(2021, 09, 24, 19, 00, 00),
                Category = "THEATHER"
            };
            EventItem eventItem3 = new EventItem
            {
                Id = 3,
                Name = "ÓZ, A CSODÁK CSODÁJA - musical két részben",
                IsFavorite = false,
                Description = "<p>Fel a fényeket és mosolyt mindenki arcára! Kezdődjön a varázslat&nbsp;</span><span>a sárga köves úton</span><span>!</span></p>" +
                              "<p>Az Óz, a csodák csodája egy kislány hihetetlen kalandja, aki azért küzd, hogy megmentse a világot és segítsen a barátain." +
                              " Ez a történet egy nagyszerű keveréke a vidámságnak, a boldogságnak és a humornak, ami ugyanakkor mély tartalmakat közvetít a gyermekek és a felnőttek felé is.</p>" +
                              "<p>Napjainkban, ezekben a bonyolult színházi időkben, nagyon fontos a boldogságról és a fényről beszélni. Gyönyörű zene, nagyszerű előadás, tehetséges színészek várják a nézőket!</p>" +
                              "<p>Ez az igazán szívhez szóló történet Ilja Bocsarnikovsz&nbsp;rendezésében kel életre a Szabadtéri színpadán.</p>" +
                              "<p><strong>A külföldi érdeklődőkre való tekintettel augusztus 28-án angol felirattal tekinthető meg az Óz, a csodák csodája című előadás a Nagyerdei Szabadtéri Színpadon.</strong></span></span></span>",
                Location = "Nagyerdei Szabadtéri Színpad<br>4032 Debrecen, Nagyerdei park 6.",
                City = "Debrecen",
                Image = "https://pb2.jegy.hu/imgs/system-4/program/000/121/891/oz-a-csodak-csodaja-musical-ket-reszben-474-279-171888.jpeg",
                EventUrl = "https://www.jegy.hu/program/oz-a-csodak-csodaja-musical-ket-reszben-121891",
                UserId = 1,
                Date = new DateTime(2021, 08, 27, 19, 30, 00),
                Category = "THEATHER"
            };
            EventItem eventItem4 = new EventItem
            {
                Id = 4,
                Name = "Rómeó és Júlia",
                IsFavorite = false,
                Description = "<p>'Amíg Rómeó a csinos Rózába szerelmes, egy kicsit érzékeny, de pontosan úgy viselkedik és úgy beszél, mint a többi. Abban a percben, amikor Júliát megismeri," +
                    " elkezd félrebeszélni. Szokatlan szavakat mond és azokat furcsa értelemben használja. Néha bizarr, többször groteszk, még többször teljesen értelmetlen." +
                    " Minél bolondabbul szeret, annál bolondabbul viselkedik és beszél./…/ Úgy látszik, hogy Rómeó megőrült. Erről szó sincs. Az élet csak akkor kezdődik," +
                    " ha az ember nem tudja, hogy mi lesz.' (Hamvas Béla)</p>" +
                    "<p>'Ebben a mostani rendkívüli időben még tisztábban látszik, hogy igazi nagy szenvedélyekről érdemes szólnunk, mert ezek nem vesztik érvényüket." +
                    " Egyszerűen csak mesélni a győzedelmes költészet nyelvén az ifjúság lázáról, a szerelemről, mint legcsodálatosabb ajándékról, és annak elpusztíthatatlanságról." +
                    " A gravitáció törvényei nem vonatkoznak az igaz szerelemre, azt nem tudja elnyomni, sárba rántani a világi acsarkodás sem, túllép minden félelmen," +
                    " és minden köteléktől szabadon összeköti az eget a földdel.'</p>" +
                    "<p>'Előadásunk tere, mely az eredeti reneszánsz világot is idézi majd, hatásában mégis kortalan lesz. Mondhatnánk, hogy mindez a lentről felfelé mozgást" +
                    " mutatja az időtlenség motorikáját indítva be. A szövegmondás is elemelt, énekszerű, az előadás atmoszféráját megteremtő zenei válogatás pedig ezer" +
                    " évet ölel majd át. Mindez azonban egy dologról hivatott szólni: a szerelem elsöprő diadaláról. Megkérdezhetnénk persze, hogy hol itt a diadal," +
                    " hisz a sorsszerű véletlenek is közrejátszanak: például egy váratlan járvány miatt megkésett híradás okán, meghalnak a fiatalok. De vajon itt" +
                    " ér-e véget a történet? Vagy éppen a halált is legyőző szerelem üdvtörténetét olvassuk ki Shakespeare e halhatatlan művéből?' (Vidnyánszky Attila rendező)</p>" +
                    "<p>'Szerelem és halál, mindig is rokonságban áltak egymással. A beteljesülés ódiuma már követhetetlen, amikor megszületik a felismerés: csak magán a drámán," +
                    " az előadáson keresztül juthatunk e sodrás nyomába – nézőként és alkotóként, egyaránt.'</p>",
                Location = "Nemzeti Színház, Nagyszínpad - Budapest IX. ker. Bajor Gizi park 1.",
                City = "Budapest",
                Image = "https://nemzetiszinhaz.hu/image?src=uploads/images/2020_2021/Romeo_es/net_Romeo_eorifoto-3248.jpg&w=960&h=630&zc=1&a=t",
                EventUrl = "https://nemzetiszinhaz.hu/eloadas/romeo-es-julia",
                UserId = 1,
                Date = new DateTime(2021, 10, 14, 18, 30, 00),
                Category = "THEATHER"
            };

            EventItems = new[] { eventItem, eventItem2, eventItem3, eventItem4 };
        }
    }
}