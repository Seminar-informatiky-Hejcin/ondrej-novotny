# Operační systémy

Operační systém (OS) je základní software, který řídí hardware a umožňuje běh dalších programů. Je to prostředník mezi hardwarem a aplikacemi.

## Role operačního systému

OS zajišťuje:

- **správu procesoru** - rozhoduje, který program dostane procesor a na jak dlouho,
- **správu paměti** - každý program má vlastní oddělený prostor v paměti,
- **souborový systém** - jak jsou uložena data na disku,
- **správu zařízení** - komunikace s hardwarem přes ovladače,
- **bezpečnost** - uživatelské účty, práva, izolace programů.

Bez OS by každý program musel umět komunikovat s konkrétním hardwarem sám.

## Jádro vs. operační systém

Jádro (kernel) je nejnižší a nejdůležitější část OS. Přímo ovládá hardware a zajišťuje všechny úkoly z předchozí kapitoly.

Celý operační systém ale tvoří víc než jádro:

1. jádro (včetně ovladačů),
2. systémové knihovny - přes ně aplikace volají jádro,
3. systémové služby - běží na pozadí (přihlašování, síť, logování),
4. systémové nástroje - příkazová řádka, správce souborů, správce balíčků,
5. uživatelské rozhraní - příkazová řádka nebo grafické prostředí.

Jádro je motor, operační systém je celé auto.

## Architektura

Počítač si můžeme představit jako vrstvy:

```
Aplikace
Shell / grafické rozhraní
Systémové služby a nástroje
Systémové knihovny
------ systémová volání ------
JÁDRO
HARDWARE
```

Procesor má dva režimy:

- **uživatelský režim** - v něm běží aplikace, nesmí přímo na hardware,
- **režim jádra** - v něm běží jádro, má plný přístup k hardwaru.

Když aplikace potřebuje např. otevřít soubor, zavolá **systémové volání (syscall)**. Procesor přepne do režimu jádra, jádro operaci provede a vrátí výsledek. Díky tomu chyba v aplikaci neshodí celý systém.

## Multitasking

Počítač má desítky až stovky běžících procesů, ale jen několik jader procesoru. OS proto rychle střídá procesy a každému dává krátký časový úsek. Uživatel má dojem, že vše běží současně. Na vícejádrových procesorech část úloh opravdu běží paralelně.

Proces je běžící instance programu.

Typy multitaskingu:

- **kooperativní** - procesy si procesor předávají dobrovolně, jeden zamrzlý program zablokuje všechno (historicky),
- **preemptivní** - OS sám odebere procesor, když čas vyprší (dnešní standard).

## Unix

Unix je rodina operačních systémů, z které vychází většina dnešních systémů (kromě Windows).

### Jak vznikl

- V 50. letech žádné OS nebyly, počítač dělal jednu úlohu najednou.
- V 60. letech vznikl nápad **sdílení času** - jeden počítač používá víc lidí. Velký projekt Multics byl ale příliš složitý a Bell Labs z něj v roce 1969 odstoupily.
- V roce **1969** napsali **Ken Thompson a Dennis Ritchie** v Bell Labs jednodušší systém. Název **Unix** je slovní hříčka na Multics.
- V roce **1973** byl Unix přepsán do jazyka **C** (který vytvořil Ritchie). Do té doby se systémy psaly v assembleru a byly vázané na konkrétní procesor. Unix v C šel přenést na jiný hardware, proto se rozšířil.

### Filozofie Unixu

- Každý program dělá jednu věc a dělá ji dobře.
- Programy se skládají dohromady pomocí **rour** (pipes):

```bash
ls | grep txt | wc -l
```

- Všechno je soubor - i zařízení se ovládají jako soubory.

Aby si různé Unixy byly kompatibilní, vznikl standard **POSIX**.

### Potomci Unixu

- **BSD** - vznikla na univerzitě v Berkeley. Z ní jsou FreeBSD, OpenBSD a také jádro Darwin, na kterém stojí **macOS a iOS**.
- **GNU a Linux** - v roce 1983 začal Richard Stallman projekt GNU (svobodná náhrada Unixu), ale chybělo mu jádro. V roce **1991** napsal Linus Torvalds jádro **Linux**.

## Linux: jádro vs. distribuce

Linux je pouze **jádro**. Operačním systémem se stává až spojením s GNU nástroji, knihovnami, správcem balíčků a desktopovým prostředím. Takovému balíčku říkáme **distribuce** (Debian, Ubuntu, Fedora, Arch).

Distribuce mají společné jádro, ale liší se tím, co je okolo (nástroje, správce balíčků, výchozí nastavení).

## Android

Android používá jádro Linux, ale **není to linuxová distribuce**:

- má vlastní systémovou knihovnu (Bionic),
- aplikace běží v prostředí Android Runtime a jsou psané v Javě a Kotlinu,
- běžné linuxové programy na něm nefungují.

Stejné jádro tedy může sloužit různým operačním systémům.

## Windows

Windows nevychází z Unixu. Vznikl z MS-DOS (1981) a moderní verze stojí na jádře **NT** (1993).

## Nejpoužívanější operační systémy

| Oblast | Systémy |
| --- | --- |
| PC a servery | Windows, Linux (distribuce), macOS |
| Mobilní zařízení | Android, iOS |

Zhruba platí: Windows dominuje na stolních počítačích, Linux na serverech a superpočítačích, Android a iOS na mobilech.

## PC vs. mobilní OS

| Oblast | PC OS | Mobilní OS |
| --- | --- | --- |
| Ovládání | klávesnice, myš, více oken | dotyk, gesta, malá obrazovka |
| Aplikace na pozadí | volnější | omezené kvůli baterii |
| Hardware | velká variabilita | uzavřenější ekosystém |
| Instalace | z různých zdrojů | hlavně oficiální obchod |
| Bezpečnost | oprávnění uživatele | sandbox pro každou aplikaci |

Jádro může být stejné (Android a Linux, iOS a macOS), liší se vrstva nad ním.

## Shrnutí

- OS je prostředník mezi hardwarem a aplikacemi.
- Jádro je jeho nejdůležitější část, celý OS zahrnuje i knihovny, služby, nástroje a rozhraní.
- Multitasking umožňuje běh více úloh najednou.
- Unix (1969) položil základy: přenositelnost díky C, malé nástroje, roury, všechno je soubor.
- Linux je jádro, distribuce jsou operační systémy. Android je samostatný OS nad jádrem Linux.
