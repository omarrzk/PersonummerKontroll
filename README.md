# Personnummerkontrollapplikation

## Lokal körning och testning

### Steg 1: Klona projektet
```bash
git clone https://github.com/omarrzk/PersonummerKontroll.git
cd PersonnummerKontroll
```

### Steg 2: Kör personnummerkontrollapplikationen
```bash
dotnet run
```

### Steg 3: Kör enhetstester
```bash
cd PersonnummerKontroll.Tests
dotnet test
```

## Docker

### Steg 1: Installera Docker
Besök [Docker-webbplatsen](https://www.docker.com/products/docker-desktop) och ladda ner och installera Docker Desktop.

### Steg 2: Bygg Docker-image
```bash
cd PersonnummerKontroll
docker build -t personnummer-kontroll .
```

### Steg 3: Kör Docker-container
```bash
docker run -it personnummer-kontroll
```

## Information om svenskt personnummer

Formatet för svenskt personnummer är ÅÅMMDD-XXXX, där:
- ÅÅ representerar de två sista siffrorna i födelseåret.
- MM representerar månaden.
- DD representerar dagen.
- XXXX representerar den fyrsiffriga personliga koden.

För att avgöra kön kan du titta på den näst sista siffran i den personliga koden (XXXX). Jämna siffror representerar kvinnor, medan udda siffror representerar män.

## Applikationsfunktionalitet

Applikationen fungerar genom att användaren anger ett personnummer på 12 siffror. Sedan körs applikationen och ger ett resultat om det är ett giltigt personnummer eller inte.
