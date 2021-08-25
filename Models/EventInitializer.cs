﻿using System;

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
                Subtitle = "zenés-bábos pszichothriller egy részben",
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
                Image = "https://budapestbabszinhaz.hu/wp-content/uploads/2017/09/EDV_1129.jpg",
                EventUrl = "https://www.jegy.hu/program/semmi-40179",
                UserId = 1,
                Date = new DateTime(2021, 9, 29, 13, 00,00),
                Category = "THEATHER"
            };
            EventItem eventItem2 = new EventItem
            {
                Id = 2,
                Name = "Giselle",
                Subtitle = "kortárs balett",
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
                Image = "https://szabadter.hu/old/media/k2/items/cache/977cdec1a36f3c618d5073db7f5a2323_XL.jpg",
                EventUrl = "https://www.jegy.hu/program/giselle-90843",
                UserId = 1,
                Date = new DateTime(2021, 09, 24, 19, 00, 00),
                Category = "THEATHER"
            };
            EventItem eventItem3 = new EventItem
            {
                Id = 3,
                Name = "ÓZ, A CSODÁK CSODÁJA",
                Subtitle = "musical két részben",
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
                Subtitle = "dráma két felvonásban",
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
                Location = "Nemzeti Színház, Nagyszínpad <br> Budapest IX. ker. Bajor Gizi park 1.",
                City = "Budapest",
                Image = "https://nemzetiszinhaz.hu/image?src=uploads/images/2020_2021/Romeo_es/net_Romeo_eorifoto-3248.jpg&w=960&h=630&zc=1&a=t",
                EventUrl = "https://nemzetiszinhaz.hu/eloadas/romeo-es-julia",
                UserId = 1,
                Date = new DateTime(2021, 10, 14, 18, 30, 00),
                Category = "THEATHER"
            };
            EventItem eventItem5 = new EventItem
            {
                Id = 5,
                Name = "NEHÉZ ISTENNEK LENNI",
                Subtitle = "Mundruczó Kornél/Proton Színház",
                IsFavorite = false,
                Description = "<p>NEHÉZ ISTENNEK LENNI<br><br>BEMUTATÓ: 2010. MÁJUS 21. KUNSTENFESTIVALDESARTS, BRÜSSZEL, BELGIUM<br>" +
                              "AZ ELŐADÁS HOSSZA: 110 PERC<br><br>Két kamion áll az út szélén. Árut cserélnek: három fiatal nőt." +
                              " Egy nagyszabású terv készül, ha sikerül, másnapra minden megváltozik. A leleplezés kulcsa a fiú," +
                              " akit eddig elrejtettek a világ szeme elől. Nem hibázhatnak, ezért a raktér falai között új törvények születnek." +
                              " Aki nem engedelmeskedik, nem térhet haza. Azonban közöttük van egy idegen, aki bármikor közbeavatkozhatna" +
                              ", mégsem teszi meg - parancsot kapott rá. Mint az Isten, megteremtve a világot, némán szemléli teremtményeit." +
                              " Egy ideig. De meddig lehet csupán megfigyelőnek maradni?<br><br>Az előadás szereposztása:<br><br>Váradi Annamária:" +
                              " LÁNG Annamária<br>Andrea:&nbsp;GERA Marina<br>Zita: KISS Diána Magdolna<br>Emőke:&nbsp;STEFANOVICS Angéla<br>dr." +
                              " Varjassy Károly: RÁBA Roland<br>Attila: BÁNKI Gergely<br>Omar: KATONA László<br>János: FRIEDENTHAL Zoltán<br>" +
                              "Varjassy Rudolf: SZEMENYEI János<br>Doktor: NAGY Zsolt<br><br>Díszlet, jelmez: ÁGH Márton<br>" +
                              "Írta: MUNDRUCZÓ Kornél, BÍRÓ Yvette<br>Dramaturg: PETRÁNYI Viktória, ZABEZSINSZKIJ Éva<br>" +
                              "Zene: SZEMENYEI János<br>Rendezőasszisztens: KÖVÉCS Luca<br>Rendező: MUNDRUCZÓ Kornél<br><br>" +
                              "Producer: BÜKI Dóra<br>Műszaki vezető: ÉLTETŐ András<br>Fény: RIGÓ Zoltán<br>Hang: BELÉNYESI Zoltán/REMBECZKI János<br>" +
                              "Kellék: NAGY Gergely<br>Öltöztető: CSELIK Jánosné<br><br>Az előadásról bővebben:<br>https://protontheatre.hu/hu/eloadas/nehez-istennek-lenni</p>",
                City = "Budapest",
                Location = "Örkény István Színház Nonprofit Kft., Proton Színház - Gyömrői úti nézőtér<br>1183 Budapest, Gyömrői út 156.",
                Image = "https://protontheatre.hu/sites/protontheatre.hu/files/styles/large/public/nehezistenneklenni_agh_marton_5.jpg?itok=nGD2-32D",
                EventUrl = "https://www.jegy.hu/program/proton-szinhazmundruczo-kornel-nehez-istennek-lenni-124208",
                UserId = 1,
                Date = new DateTime(2021, 8, 28, 20, 30,00),
                Category = "THEATHER"
            };
            EventItem eventItem6 = new EventItem
            {
                Id = 6,
                Name = "The black paintings/Blue",
                Subtitle = "Szegedi Kortárs Balett",
                IsFavorite = false,
                Description = "<p>Horizont Táncfesztivál - The black paintings / Blue <br>Időtartam: 105 perc<br><br><strong>The Black Paintings &nbsp;" +
                              "</strong><br>Francisco Goya spanyol festő halálát követően tizennégy freskót találtak madridi otthonának falain, ahol utolsó éveit töltötte." +
                              " A képeken erőteljes, kísértő motívumok hangsúlyozták a festő elmezavartól való félelmét és az emberiség sorsára vonatkozó sivár jövőképét." +
                              " Linning Goya festményeit saját, a mai társadalomra vonatkozó víziójával együtt kelti életre és helyezi a klasszikus világosság és sötétség" +
                              " közti harc történetébe.Elénk tárja a küzdelmet, ahogy fényt és reményt keresünk a krízis, zsarnokság és kétségbeesés idejében. Arvo Pärt 4." +
                              " Szimfóniájának természetfeletti zenéjére hangolva Nanine Linning Hésziodosz: Istenek születése című verséből és Goya vitatottan legsötétebb," +
                              " legendás Fekete Festmények sorozatának egyikéből, a Saturnusz felfalja gyermekét című alkotásából merített ihletet. A The Black Painting" +
                              " megbízója 2015-ben a Gauthier Dance együttes volt. A Szegedi Kortárs Balett számára ezt kiegészítve Linning egy második részt is koreografál" +
                              " a Fekete Festmények sorozat rövid történeteinek folytatásaként. <br><br>Táncolják:<br>Heim Boglárka, Vincze Lotár, Marie Vilette, Bocsi Petra," +
                              " Liszkai Zsófia, Nier Janka, <br>Diletta Ranuzzi, Francesco Totaro, Adam Bobák, Czár Gergely, Graziano Bongiovanni, Kiss Róbert<br><br>Zene:" +
                              " Arvo Pӓrt: Adam’s Lament, Symphony No. 4 „Los Angeles”, part 2: Affannoso<br>Jelmez: Nanine Linning <br>Fény: Stadler Ferenc<br>Koreográfus:" +
                              " Nanine Linning<br><br><br><strong>Blue</strong> <br>Az előadásban az alkotók a kék színt egyfajta szimbólumként használva, annak számtalan" +
                              " jelentése köré építik darabjukat. Egyszerűen beszínezik a szereplőket, és az ilyen módon csoportok és egyének között létrejövő színbeli," +
                              " formai különbségekből adódó játékkal sokféle asszociációra késztetik a nézőket. A társadalmi konvenciókban zárt ember szenvedését," +
                              " szabadságvágyát, vele szemben az egyéni ambíciókat, a transzcendencia jelenlétét elfojtó közösség erejét mutatja meg a mű. Két ellentétes" +
                              " világ váltakozásának állandó körforgását, szabadság és kötöttség ellentétét, ugyanakkor összetartozását fejtegetik az alkotók. Az angol" +
                              " nyelvben a „blue” szó a szín jelölésén túl plusz tartalmat is hordozhat; egyfajta szomorkás hangulatot is jelent. Ez a többletjelentés" +
                              " indokolja a mű címválasztását.&nbsp; &nbsp;<br><br>Táncolják:<br>Bocsi Petra, Heim Boglárka, Hudacsek Hanna, Liszkai Zsófia, Diletta" +
                              " Ranuzzi , Nier Janka, Nyeste Adrienn,<br>Kiss Réka, Marie Vilette, Adam Bobák, Graziano Bongiovanni, Kiss Róbert, Vincze Lotár," +
                              " Francesco Totaro<br><br>Zene: montázs<br>Zenei szerkesztő: Demkó Mátyás<br>Jelmeztervező és kivitelező: D’ANGE " +
                              "<br>Fény: Stadler Ferenc<br>Társkoreográfusok: Kurucz Sándor, Czár Gergely<br>Koreográfus: Juronics Tamás</p>",
                City = "Miskolc",
                Location = "Miskolci Nemzeti Színház, Nagyszínház<br>3525 Miskolc, Déryné utca 1.",
                Image = "http://www.nemzetitancszinhaz.hu/file/repertoar/lg-szkb_blue_0072_ajanlo.jpg",
                EventUrl = "https://www.jegy.hu/program/the-black-paintingsblue-szegedi-kortars-balett-hun-123757",
                UserId = 1,
                Date = new DateTime(2021, 8, 29, 19, 00,00),
                Category = "THEATHER"
            };
            EventItem eventItem7 = new EventItem
            {
                Id = 7,
                Name = "Az ügynök halála",
                Subtitle = "Örkény István Színház",
                IsFavorite = false,
                Description = "<p>Willy Loman egyre több időt tölt a múltban, képzelet és valóság határán. Pénzt már nem keres, tartaléka nincs." +
                              " Fiai sodródó léhűtők, nagy tervekkel, amiket ő maga ültetett a fejükbe. Neki is nagy tervei voltak, pénz, dicsőség," +
                              " boldogság, de csak háromszáz havi letörlesztett banki részlet lett belőlük. Az álmok álmok maradtak – és felfalták a maradék jövőt.</p>",
                City = "Budapest",
                Location = "Örkény István Színház, Színházterem<br>1075 Budapest, Madách tér 6.",
                Image = "https://puskelzsolt.com/sites/default/files/styles/original/public/gallery/592/galeria/az-ugynok-halala-orkeny-istvan-szinhaz-0_7.jpg?itok=naK_TcnV",
                EventUrl = "https://www.jegy.hu/program/az-ugynok-halala-67668",
                UserId = 1,
                Date = new DateTime(2021, 10, 6, 19, 0,00),
                Category = "THEATHER"
            };
            EventItem eventItem8 = new EventItem
            {
                Id = 8,
                Name = "A Démon gyermekei",
                Subtitle = "Pintér Béla És Társulata",
                IsFavorite = false,
                Description = "<p>„Kétezerkettõ nyarán történt augusztus hó hetedik napján," +
                              " Tizennégy óra harminc perckor jelentették a rendõrségen, Az elsõ kerületi kapitányságon, hogy eltûnt egy asszony a Budai Várból." +
                              "Y. Kovácsné- Faragó Zsuzsa, a japán kultúra professzora, Néprajzkutató és műfordító, a piacra indult hetedike reggel," +
                              " De sem a csarnokban, sem otthonában nem látták őt soha többé.</p>",
                City = "Budapest",
                Location = "Szkéné Színház, Színházterem<br>1111 Budapest, Műegyetem rkp. 3.",
                Image = "https://pb2.jegy.hu/imgs/system-4/program/000/027/225/pinter-bela-es-tarsulata-a-demon-gyermekei-original-69111.jpg",
                EventUrl = "https://www.jegy.hu/program/pinter-bela-es-tarsulata-a-demon-gyermekei-27225",
                UserId = 1,
                Date = new DateTime(2021, 9, 30, 20, 00,00),
                Category = "THEATHER"
            };
            EventItem eventItem9 = new EventItem
            {
                Id = 9,
                Name = "Nők az idegösszeomlás szélén",
                Subtitle = "",
                IsFavorite = false,
                Description = "<p>Jeffrey Lane – David Yazbek – Pedro Almodovar: NŐK AZ IDEGÖSSZEOMLÁS SZÉLÉN<br>musical<br>Esőnap: 2021. szeptember 4.(szombat)" +
                              " 20:30 <br><br>Pedro Almodóvar a film világába a musical alapjául szolgáló filmmel robbant be 1988-ban, és rögvest 25 különböző díjat" +
                              " be is zsebelt. Sajátosan, ugyanakkor végtelen kedvességgel hangolt fordulatos történet lányokról, asszonyokról, elhagyott és elhagyás" +
                              " előtt álló nőkről. Mindnek legalább két ellensége van: a férfi, valamint (minimum) egy másik nő. A musicalben jóakarók, ellenségek és" +
                              " nők minden mennyiségben, hol gyalog, hol taxival kergetik érzelmeiket, háttérben a reklámfilm-forgatások kaotikus világa, rögzítőkön" +
                              " hagyott telefonüzenetek sora, na meg nyugtatók a turmixgépben. Temperamentumos, latinos zene és igazi mediterrán életérzés a színpadon." +
                              " A női lelket félelmetesen ismerő szerzők műve a világ egyik legszebb – és legváltozatosabb – alkotóeleméről: a NŐ-ről. <br>" +
                              "<br>Szereplők<br>Pepa............................................................ SÁRI ÉVI<br>" +
                              "Ivan.............................................................. BUCH TIBOR<br>" +
                              "Lucia............................................................ FÉSŰS NELLY<br>" +
                              "Carlos.......................................................... KRAJNIK-BALOGH GÁBOR<br>" +
                              "Candela....................................................... MOLNÁR GYÖNGYI<br" +
                              ">Paulina........................................................ KOVÁCS LOTTI<br>" +
                              "Marisa......................................................... CSÁKI EDINA<br>" +
                              "Taxisofőr...................................................... NAGY BALÁZS<br>" +
                              "Rendező / Főfelügyelő / Bíró....................... PÁL TAMÁS<br>" +
                              "Házfelügyelőnő / Cristi / Nyomozó.............. ZORGEL ENIKŐ<br><br>" +
                              "Látványtervező: ZÖLDY Z. GERGELY<br>Rendező: TASNÁDI CSABA<br><br>" +
                              "Veres 1 Színház előadása<br>Az előadás hossza: 1 óra 55 perc, egy szünettel.<br>" +
                              "Rózsakert Szabadtéri Színpad</p>",
                City = "Budapest",
                Location = "Móricz Zsigmond Színház, Rózsakert Szabadtéri Színpad<br>4400 Nyíregyháza, Benczúr tér 22.",
                Image = "https://pb2.jegy.hu/imgs/system-4/program/000/124/975/nok-az-idegosszeomlas-szelen-original-171650.jpg",
                EventUrl = "https://www.jegy.hu/program/nok-az-idegosszeomlas-szelen-124975",
                UserId = 1,
                Date = new DateTime(2021, 9, 10, 19, 00,00),
                Category = "THEATHER"
            };
            EventItem eventItem10 = new EventItem
            {
                Id = 10,
                Name = "Tündöklő Középszer",
                Subtitle = "Pintér Béla és Társulata",
                IsFavorite = false,
                Description = "<p><i>Mert van a Stradivari és egy átlagos hegedű,<br>" +
                              "A Stradivari Stradivari a másik meg középszerű!<br>" +
                              "És én hazudhatnék neked tovább, de nem teszem!<br>" +
                              "Te nem középszerű vagy, hanem tehetségtelen.</i></p>" +
                              "<p>Pintér Béla és Társulata: Tündöklő Középszer <br><br>“Mert van a Stradivari és egy átlagos hegedű, A Stradivari Stradivari" +
                              " a másik meg középszerű! És én hazudhatnék neked tovább, de nem teszem! Te nem középszerű vagy, hanem tehetségtelen. " +
                              "Sokféleképpen próbáltalak instruálni téged, Mondtam csúnyát, néha szépet, Ha úgy tetszik elhintettem a magot, És vártam," +
                              " hogy a tehetség majdcsak kinő…<br>És ebben tényleg én is hibás vagyok, Mert neked minden színpadon töltött perced elpocsékolt" +
                              " idő”<br><br>Szereplők:<br>Korpás János: Thuróczy Szabolcs<br>Géza: Pintér Béla<br>Judy: Szalontay Tünde<br>Madár: Fodor Annamária<br>" +
                              "Szücsi: Enyedi Éva<br>Juci: Herczenik Anna<br>Bölény: Fáncsik Roland<br>Héra: Roszik Hella<br>Dínó: Quitt László<br>Újházy Miska:" +
                              " Kéménczy Antal<br><br>Dramaturg: Enyedi Éva<br>Zene: Kéménczy Antal<br>Jelmez: Benedek Mari<br>Jelmeztervező munkatársa: Kiss Julcsi<br>" +
                              "Énektanár: Berecz Bea<br>Tér: Tamás Gábor<br>Fény: Varga László<br>Hang: Belényesi Zoltán<br><br>Produkciós munkatárs: Jékely Anna<br>" +
                              "Rendező munkatársa: Hajdú Rozi<br>Asszisztens: Hornyák Dóra<br><br>Írta és rendezte: Pintér Béla<br>Támogatók: NKA, NEFMI<br><br>" +
                              "Az előadás hossza: 100 perc, szünet nélkül<br>Korhatár: 16 év<br><br></p>",
                City = "Budapest",
                Location = "Pintér Béla és Társulata, UP Újpesti Rendezvénytér<br>1042 Budapest, Szent István tér 13-14.",
                Image = "https://lh3.googleusercontent.com/proxy/cBSBO44PAQalaQAczLJhxYMUf9-dgkoaHONQ5OPb3cC4i1DPsU7esSjx_4gYUWicJPdE4W3YvLjGIE-PiiJmyGO09zBcSlwTqrzlmqf3R1Tqw9Vh98FL1w",
                EventUrl = "https://www.jegy.hu/program/pinter-bela-es-tarsulata-tundoklo-kozepszer-113588",
                UserId = 1,
                Date = new DateTime(2021, 9, 13, 20, 00,00),
                Category = "THEATHER"
            };
            EventItem eventItem11 = new EventItem
            {
                Id = 11,
                Name = "Nasip Kismet",
                Subtitle = "(TR/HU)",
                IsFavorite = false,
                Description = "<p>Nasip Kismet (TR/HU)<br><br>Közreműködik:<br>Arif Erdem Ocak – gitár, ének<br>Mester Dániel – szaxofon," +
                              " klarinét<br>Szegő Dávid - dob<br>Eged Márton – basszusgitár<br>Smuk Tomi – ütőhangszerek<br>Derya Ocak – vokál<br>" +
                              "<br>A „szerencsés együttállás” kifejezés nemcsak a lehető legközelebbi magyar megfelelője a Nasip Kısmet török zenekarnévnek," +
                              " de tökéletesen leírja ennek a nemzetközi zenekarnak a több műfajban gyökerező, mégis autentikus zenéjét. Azt, ahogyan a népzenei" +
                              " dallamok váratlan akkordmeneteken keresztül pszichedelikus kitörésekbe torkollanak, hogy aztán lágy, jazz-fúziós fuvallatok által" +
                              " jöjjön megkönnyebbülés. A Nasip Kısmet ötlete a török születésű, 2010 óta Budapesten élő zenész, Arif Erdem Ocak fejéből pattant" +
                              " ki, aki a török zenei színtér jól ismert muzsikusa. A zenekar korokon átívelő hangzásvilága eddig soha nem hallott történeteket mesél" +
                              " a szívről és lélekről. A török zene mélyre nyúló történeti gyökerei itt a gitár és a ritmusszekció intenzív jelenlétében köszönnek" +
                              " vissza, összenőve a szaxofon és a billentyűs hangszerek friss hajtásaival, amelyek így különös gyümölcsöt hoznak. A hangok között" +
                              " szinte tapinthatóvá válnak az idő barázdái, amelyek a pszichedelikus transzcendencia mámorító rezgéseit generálják.<br><br><strong>" +
                              "Az asztalfoglalás a jegyvásárlás során automatikusan megtörténik.</strong><br>Vacsoravendégeinknek 19 órai érkezést javaslunk.<br>" +
                              "Az asztalfoglalásokat legkésőbb 20 óráig tudjuk fenntartani!</p>",
                City = "Budapest",
                Location = "Budapest Music Center, Opus Jazz Club<br>1093 Budapest, Mátyás u. 8.",
                Image = "https://pb2.jegy.hu/imgs/system-4/program/000/124/738/nasip-kismet-trhu-original-170396.jpg",
                EventUrl = "https://www.jegy.hu/program/nasip-kismet-trhu-124738",
                UserId = 1,
                Date = new DateTime(2021, 8, 29, 20, 00,00),
                Category = "CONCERT"
            };
            EventItem eventItem12 = new EventItem
            {
                Id = 12,
                Name = "GUZSALYAS BÁL",
                Subtitle = "Moldvai és gyimesi táncház",
                IsFavorite = false,
                Description = "<p>NYÁRI GUZSALYAS – BATYUS BÁL<br><br>Ha húzza e szüve s taszítja e mája, akkor legyen ott minden Guzsalyas bálban. Mük várjuk! " +
                              "Moldvai és gyimesi táncház a művelődési központ belső kertjében, az Aventinus udvaron a SOMOS, SZIGONY, FANFARA COMPLEXA zenekarokkal.<br>" +
                              "<br>Az intézménybe történő belépésre és tartózkodásra az aktuális kormányrendelet szerinti szabályok érvényesek.</p>",
                City = "Budapest",
                Location = "Marczibányi Téri Művelődési Központ, Marczi -Színházterem<br>1022 Budapest, Marczibányi tér 5/a",
                Image = "https://folkradio.blob.core.windows.net/media/events/23052/59058/2WJ_image.png",
                EventUrl = "https://www.jegy.hu/program/guzsalyas-bal-46184",
                UserId = 1,
                Date = new DateTime(2021, 8, 26, 19, 00,00),
                Category = "CONCERT"
            };
            EventItem eventItem13 = new EventItem
            {
                Id = 13,
                Name = "In Memoriam Chet Baker Trio",
                Subtitle = "",
                IsFavorite = false,
                Description = "<p>A trio három éve azzal a céllal alakult, hogy újra megteremtse a trombitás legenda, Chet Baker szellemiségét tükröző jazz kamarazenélést." +
                              " Chet Baker sokféle felállásából mi a trombita-gitár-nagybőgő elegyét választottuk, ez áll legközelebb a szívünkhöz." +
                              " A zenekar a művész Bebop és a Cool korszakát dolgozza fel, igyekezve Chet repertoárjából válogatni. A zene mellé némi ismeretterjesztés is" +
                              " jár, hogy a néző teljes képet kapjon Bakerről, vagy adott esetben az előadott művekről. <br><br>Zenekari tagok: Várvölgyi Szabolcs - " +
                              "gitár<br> Miskolczi Márk - nagybőgő<br>Sári Szabolcs - trombita</p>",
                City = "Budapest",
                Location = "FÉM Arts & Café, Fém Arts&Café<br>1056 Budapest, Váci utca 40. (bejárat az Irányi utcából)",
                Image = "https://pb2.jegy.hu/imgs/system-4/program/000/114/916/in-memoriam-chet-baker-trio-original-153175.jpg",
                EventUrl = "https://www.jegy.hu/program/in-memoriam-chet-baker-trio-114916",
                UserId = 1,
                Date = new DateTime(2021, 9, 15, 20, 00,00),
                Category = "CONCERT"
            };
            EventItem eventItem14 = new EventItem
            {
                Id = 14,
                Name = "Oroszok-Viszockij-est",
                Subtitle = "irodalmi-zenés est",
                IsFavorite = false,
                Description = "<p>Oroszok – Viszockij-est<br><br>Harsányi Attila, Jászai Mari díjas színművész és Vihula Mihajlo gitárművész irodalmi-zenés estje<br><br>Egy hatlövetű pisztoly, egy golyó, megpörgetni a dobtárat és lőni. Halál vagy dicsőség. A legrizikósabb szerencsejáték. Egészen extrém. Ilyenre csak az oroszok képesek.<br><br>Az előadásban tizenkét dal hangzik el Vlagyimir Szemjonovics Viszockijtól, emellett részletek Dosztojevszkij Karamazov testvérek és Bűn és bűnhődés című regényeiből, Lermontov, Puskin verseiből, Tarkovszkij filmjeiből, de útmutatót kapunk a vodka, a pirog, a borscs és a szoljánka elkészítéséhez is. Szót ejtünk a sztálini időkről, Mengyelejev periódusos rendszeréről, az orosz rulettről és a Szputnyik–2 űrhajóról, amin Lajka kutya utazott, tehát az este folyamán szinte minden terítékre kerül, ami orosz.<br><br>„A két előadó – és így maga az előadás – szenvedélyessége átütő. Azáltal, hogy egymással játszanak, nekünk játszanak.&nbsp; Ha a dal félremegy egy oktávval, akkor újra lehet kezdeni. Az emberek hibáznak néha, és attól emberek, hogy belátják.<br><br>Nemcsak a két előadó, hanem a közönség is részévé válik az előadásnak, sőt a hangszer is önálló életre kel, és létrejön egy kétségtelen tartalom, ami nem üzenet, hanem maga az este. Itt nincs hazugság, csak szándék és egy érvényes, autentikus, minden ízében színházi (mert emberi) lenyomat”</p>",
                City = "Budapest",
                Location = "Esernyős, Belső Udvar<br>1033 Budapest, Fő tér 2.",
                Image = "https://pb2.jegy.hu/imgs/system-4/program/000/125/363/oroszok-viszockij-est-original-171210.jpg",
                EventUrl = "https://www.jegy.hu/program/oroszok-viszockij-est-125363",
                UserId = 1,
                Date = new DateTime(2021, 8, 8, 19, 00,00),
                Category = "CONCERT"
            };
            EventItem eventItem15 = new EventItem
            {
                Id = 15,
                Name = "KALÁKA",
                Subtitle = "– FERENCZI GYÖRGY ÉS A RACKAJAM",
                IsFavorite = false,
                Description = "<p>KALÁKA – FERENCZI GYÖRGY ÉS AZ 1-SŐ PESTI RACKÁK<br>Akusztikus koncert felnőtteknek<br><br>Ferenczi György és az 1-ső Pesti Rackák a Kalákával régi kedves barátok, többször koncerteztek együtt a Marczibányi téren és máshol is. Néha ilyenkor úgy írják a fellépő együttest: Rackaláka  BECZE GÁBOR, GRYLLUS DÁNIEL, GRYLLUS VILMOS, RADVÁNYI BALÁZS</p>",
                City = "Budapest",
                Location = "Marczibányi Téri Művelődési Központ, Marczi -Színházterem<br>1022 Budapest, Marczibányi tér 5/a",
                Image = "https://www.koncert.hu/uploads/concerts/kalaka--ferenczi-gyorgy-es-a-rackajam-1562967370.jpg",
                EventUrl = "https://www.jegy.hu/program/kalaka-ferenczi-gyorgy-es-a-rackajam-94736",
                UserId = 1,
                Date = new DateTime(2021, 10, 30, 19, 00,00),
                Category = "CONCERT"
            };
            EventItem eventItem16 = new EventItem
            {
                Id = 16,
                Name = "Valerij Gergijev",
                Subtitle = "és a Mariinszkij Színház Zenekara",
                IsFavorite = false,
                Description = "<p>A Mariinszkij Színházat és annak zenekarát még Nagy Katalin cárnő alapította 1783-ban. Később, a sztálini időkben a színház a Kirov Balett nevet viselte, a Szovjetunió megszűnte után, 1992-ben pedig visszatértek a Mariinszkij névhez. Az együttes élén az 1953-ban született Valerij Gergijev áll, aki hatalmas energiával és ambícióval irányítja muzsikusait. Produkciói szuggesztívak, felfogásának meghatározó eleme a maximalizmus. A koncerten megszólaló művek közül Debussy szimfonikus prelűdjéről, a Mallarmé-vers ihletése nyomán komponált Egy faun délutánjáról Pierre Boulez úgy tartotta: ezzel kezdődik a modern zene. Saint-Saëns II. zongoraversenye olyan könnyed, olyan elegáns és zenéje oly sok változékony elemet tartalmaz, hogy egy kritikusa azt írta róla: „Bachhal kezdődik és Offenbachhal fejeződik be”. Stravinsky Petruskája, mint a három nagy orosz Stravinsky-balett két másik tagja is, Párizsban került közönség elé, a tízes évek elején, a Gyagilev Balett előadásában. A zongoraverseny fiatal francia szólistáját, Alexandre Kantorowot rendkívüli tehetségnek tartják. A Fanfare című amerikai magazin kritikusa nemes egyszerűséggel így méltatta: „Liszt reinkarnációja”.</p>",
                City = "Budapest",
                Location = "Müpa, Bartók Béla Nemzeti Hangversenyterem<br>1095 Budapest, Komor Marcell utca 1.",
                Image = "https://pb2.jegy.hu/imgs/system-4/program/000/123/810/valerij-gergijev-es-a-mariinszkij-szinhaz-zenekara-original-169265.jpg",
                EventUrl = "https://www.jegy.hu/program/valerij-gergijev-es-a-mariinszkij-szinhaz-zenekara-123810",
                UserId = 1,
                Date = new DateTime(2021, 12, 15, 19, 30,00),
                Category = "CONCERT"
            };
            EventItem eventItem17 = new EventItem
            {
                Id = 17,
                Name = "1. Spájz fesztivál",
                Description = "<p>1. Spájz fesztivál - Szombati napijegy<br><br>Ha voltál már a nagyi spájzában, akkor tudod, hogy milyen szűk hely, s mégis mennyi jót s finomat tud rejtegetni! Sosem hagyod el a kamrát anélkül, hogy ne lennél tele. A mi Spájzunk sem óriási, de sok jó ember kis helyen is elfér! Ezen felül pedig dugig tömheted magad művészettel, zenével, jókedvvel, nevetéssel, apró fesztivál élménnyel! Csatlakozz hozzánk szeptember 4-én a hétvégére, s raktározd el az ott szerzett emlékeket az őszi szürkeségre, s téli fagyokra.</p>",
                IsFavorite = false,
                Subtitle = "",
                City = "Budapest",
                Location = "1. Spájz Fesztivál, A Nagy Kohó<br>2094 Nagykovácsi, Kossuth u. 1. az ipari területen",
                Image = "https://pb2.jegy.hu/imgs/system-4/program/000/119/505/1-spajz-fesztival-szombati-napijegy-original-171068.JPG",
                EventUrl = "https://www.jegy.hu/program/1-spajz-fesztival-szombati-napijegy-119505",
                UserId = 1,
                Date = new DateTime(2021, 9, 14, 9, 00,00),
                Category = "FESTIVAL"
            };
            EventItem eventItem18 = new EventItem
            {
                Id = 18,
                Name = "Víkingur Ólafsson",
                Subtitle = "zongoraest",
                IsFavorite = false,
                Description = "<p>Víkingur Ólafsson zongoraestje<br><br>„Izland Glenn Gouldja” - írta róla a New York Times. „Lélegzetelállítón briliáns zongorista” - lelkesedett játékáért a Gramophone kritikusa. A Le Monde újságírója „vulkanikus temperamentumát, hatalmas virtuozitását, a kihívások iránti fogékonyságát” dicsérte. Portréjáról kifinomult, intellektuális művészarc tekint ránk. Az 1984-ben, Reykjavíkban született Víkingur Ólafsson neve néhány éve még ismeretlenül csengett, mostanra azonban a nemzetközi muzsikustársadalom egyik legkiválóbb előadójaként tartja őt számon szakma és közönség.<br><br>Szülővárosában nőtt föl, s ott is kezdett zongorát tanulni. Mint oly sok jelentős muzsikus, ő is zenészcsaládban látta meg a napvilágot, s első mestere sem volt más, mint zongoratanárnő édesanyja. Később persze a fiatal tehetség meg sem állt New Yorkig, ahol a világhírű Juilliard School of Music növendéke lett Jerome Lowenthal és Ann Schein osztályában. Különleges képességeit jelzi, hogy nemcsak abszolút hallása van (ez azt jelenti, hogy egy-egy hangnak az adott zenei összefüggésben játszott szerepén túl a pontos magasságát is mindig tévedhetetlenül tudja: ez e, ez fisz, ez cisz), hanem szinesztéziás hallása is (mint volt egykor Alekszandr Szkrjabinnak), vagyis képzelete a hangnemeket színekkel társítja: az f-moll számára a kéket, az A-dúr a sárgát, a H-dúr a bíbort jelenti. Az elmúlt évtizedben játékával szélsebesen meghódította Európa és Amerika koncerttermeit. Ízlése sokszínű, érdeklődése tágas: lemezein Bach, Beethoven, Schubert, Chopin, Brahms mellett Philip Glass zenéje is megszólal. 2020-as albumán Debussyt társította Rameau-val. A Müpában a 18. század mestereinek terméséből válogat, C. P. E Bach, Haydn, Cimarosa és Mozart műveit tolmácsolva.<br><br>Rendező: Müpa</p>",
                City = "Budapest",
                Location = "Müpa, Bartók Béla Nemzeti Hangversenyterem<br>1095 Budapest, Komor Marcell utca 1.",
                Image = "https://pb2.jegy.hu/imgs/system-4/program/000/123/832/vikingur-olafsson-zongoraestje-original-169189.jpg",
                EventUrl = "https://www.jegy.hu/program/vikingur-olafsson-zongoraestje-123832",
                UserId = 1,
                Date = new DateTime(2021, 9, 22, 19, 30,00),
                Category = "CONCERT"
            };
            EventItem eventItem19 = new EventItem
            {
                Id = 19,
                Name = "Jézus Krisztus Szupersztár",
                Subtitle = "",
                IsFavorite = false,
                Description = "<p>Andrew Lloyd Webber és Tim Rice rockoperája forradalmasította a zenés színházat, és olyan kérdéseket vetett fel, amelyek mindmáig érvényesek. Főhőse nem csak a címszereplő Jézus, egyenrangú társa Júdás, aki kétségbeesett igyekezettel próbálja megérteni barátja cselekedeteit, de mindhiába. Kérdéseire rejtélyes válaszokat kap, és egyre világosabbá válik, hogy olyan történetbe csöppent, amelynek folytatására csekély hatása lehet - csakúgy, mint a többi szereplőnek, Pilátustól Heródesig, Mária Magdolnától Kajafásig.Egy hét eseményeibe tömörül minden emberi és emberfeletti történés: Jézus és híveinek jeruzsálemi bevonulásától a keresztre feszítésig tart a cselekmény.A. L. Webber zenéje friss és elsöprő, egyik nagy sláger követi a másikat. Egy nagy ívű pálya első mérföldköve áll most új, modern és látványos köntösben a Madách Színház publikuma elé.</p>",
                City = "Budapest",
                Location = "Madách Színház, MADÁCH SZÍNHÁZ<br>1073 Budapest, Erzsébet krt. 29-33",
                Image = "https://pb2.jegy.hu/imgs/system-4/program/000/124/729/jezus-krisztus-szupersztar-original-170811.jpg",
                EventUrl = "https://www.jegy.hu/program/jezus-krisztus-szupersztar-124729?affiliate_code=cln5-20210823-jezus_krisztus_szuperszt",
                UserId = 1,
                Date = new DateTime(2021, 10, 16, 15, 00,00),
                Category = "THEATHER"
            };
            EventItem eventItem20 = new EventItem
            {
                Id = 20,
                Name = "KLEZMELÓDIÁK",
                Subtitle = "Klezmerész Együttes koncertje",
                IsFavorite = false,
                Description = "A Klezmerész Együttes régi, oszlopos tagja a magyar klezmervilágnak, pedig a kezdet – 2004 őszén – csak hat „őrült” zenekedvelő kísérlete volt. Ami pedig a névválasztást illeti, mi is az, hogy Klezmerész? Klezmer-ész vagy klez-merész? Mindkettő érvényes rájuk, de a merészség volt a legfontosabb jellemzőjük: megálmodtak egy együttest és ez az álom a mai napig működik. Indulásuktól kezdve tudatosan a tradicionális zsidó zenét tekintik repertoárjuk súlypontjának, ennek megfelelő a hangszerek összetétele: a két vezérhangszer a klarinét és a hegedű, ehhez csatlakozik a gitár, a basszus és a dob. Különlegesség, az együttes specialitása a kétszólamú női vokál, amely egyedülálló a magyar klezmer együttesek között. A klezmer zene dallamvilága magán viseli a befogadó népek zenéit, ezért igen sokszínű: témái felölelik a zsidó élet mindennapjait és ünnepeit, ezért hol vidámak, hol szomorúak – de a szomorúságba keveredik mindig egy kis remény és a vidám dalokba is egy kis keserűség.Repertoáron szerepelnek jiddis, ladino (szefárd), héber, sőt, moldáv és óalbán dalok, valamint instrumentális számok. Hangulatukban is széles skálán mozognak – a vidám, lendületes daraboktól a melankolikusokig és az imákig. Számos hazai és külföldi fellépéseik közül kiemelkedik, hogy 2014-ben, 2015-ben és 2019-ben részt vettek az izraeli Cfáti Nemzetközi Klezmer Fesztiválon, amely egyike a világ legautentikusabb klezmerfesztiváljainak.Sajnos a 15 éves jubileumi koncertjünk tavaly a járvány miatt elmaradt, ezért annál nagyobb lelkesedéssel készülnek mostani szereplésükre, amelyen számos új számmal lepik meg a hallgatóságot. Törzsközönségük már tudja, hogy egy Klezmerész koncert igazából örömünnep, a klezmer zene ünnepe, amelyen a színpad és a nézőtér eggyé olvad: a közönség együtt énekel, táncol, él a zenészekkel, a zenével. Ez alkalommal lesz először kapható új lemezük: a Klezmelodies.Az együttes tagjai:Klein Judit– ének,Török Judit– ének,Gordon Teodóra– klarinét,Zala Judit– hegedű,Bánki Lénárd– gitár,Moharos Katalin– basszus,Garai Péter– dobok A 23. Zsidó Kulturális Fesztiválról bővebb információk itt.(A Fesztivál a Broadway Event és a BZSH közös szervezése.)* Az időpont változtatás jogát fenntartjuk!*Az előadás az időpontjában hatályban lévő kormányrendeletek, járványügyi szabályok betartásával látogatható.",
                City = "Budapest",
                Location = "Zsidó Kulturális Fesztivál 2021, Hegedűs Gyula utcai Zsinagóga<br>1136 Budapest, Hegedűs Gyula utca 3.",
                Image = "https://pb2.jegy.hu/imgs/system-4/program/000/124/772/klezmelodiak-klezmeresz-egyuttes-koncertje-original-170612.jpg",
                EventUrl = "https://www.jegy.hu/program/klezmelodiak-klezmeresz-egyuttes-koncertje-124772",
                UserId = 1,
                Date = new DateTime(2021, 8, 27, 19, 00,00),
                Category = "CONCERT"
            };

            EventItems = new[]
            {
                eventItem, eventItem2, eventItem3, eventItem4, eventItem5, eventItem6, eventItem7, eventItem8,
                eventItem9, eventItem10, eventItem11, eventItem12, eventItem13, eventItem14, eventItem15,
                eventItem16, eventItem17, eventItem18, eventItem19, eventItem20
            };
        }
    }
}