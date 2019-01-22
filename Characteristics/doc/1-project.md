# Business-Objekt

Für unser Projekt wurden die Objekte **Characteristic** und **Class** verwendet.


## Verwendete Methoden

### Characteristic

- Get List
- Get Detail
- Get Long Text
- Add Long Text
- Remove Long Text
- Create
- Delete

#### Get List

Ruft eine Liste mit Characteristic-Objekten ab. Funktionsparameter schränken die Suche ein.
Dazu müssen sign(Suchparameter Inklusive oder Exklusive), options(Optionen, z.B. größer, kleiner, gleich),
low(Suche von) und high(Suche bis, Standardwert = "_"(leer)) angegeben werden.

#### Get Detail

Gibt detaillierte Informationen zur angegeben Characteristic zurück.
Dazu muss characteristic(Characteristic welche ausgelesen werden soll) angegeben werden.

#### Get Long Text

Gibt den LongText einer angegebenen Characteristic zurück.
Dazu muss characteristic(Characteristic von der der LongText ausgelesen werden soll) angegeben werden.

#### Add Long Text

Fügt an eine angegebene Characteristic einen angegebenen LongText an.
Dazu müssen characteristic(Characteristic an die ein Longtext angefügt werden soll), format(Format des LongTexts) 
und text(Inhalt LongText) angegeben werden.

**Anmerkung:** Verwendung aufgrund von serverseitigen Problemen nicht möglich.

Meldete bei erster Verwendung "Information". Das Objekt kann danach nicht mehr verwendet werden.

#### Remove Long text

Entfernt von einer angegebenen Characteristic den LongText.
Dazu muss characteristic(Characteristic von der der LongText entfernt werden soll) angegeben werden.

**Anmerkung:** Verwendung aufgrund von serverseitigen Problemen nicht möglich.

Meldete bei erster Verwendung "Information". Das Objekt kann danach nicht mehr verwendet werden.

#### Create

Ermöglicht das Erstellen einer neuen Characteristic.
Dazu muss characteristic(Zu erstellende Characteristic) angegeben werden.

**Anmerkung:** Erstellen aufgrund von serverseitigen Problemen nicht möglich.

#### Delete

Ermöglicht das Löschen einer Characteristic.
Dazu muss characteristic(Zu löschende Characteristic) angegeben werden.

**Anmerkung:** Da nichts erstellt werden kann, sollte die Funktion nicht benutzt werden.


### Class

- Get List
- Get Detail
- Get Characteristics
- Change
- Create
- Delete

#### Get List

Ruft eine Liste mit Class-Objekten ab. Funktionsparameter schränken die Suche ein.
Dazu müssen classTypeNumber(Klassentyp), sign(Suchparameter Inklusive oder Exklusive), options(Optionen, z.B. größer, kleiner, gleich),
low(Suche von) und high(Suche bis, Standardwert = "_"(leer)) angegeben werden.

#### Get Detail

Gibt detaillierte Informationen zur angegeben Class zurück.
Dazu müssen ClassType(Klassentyp) und ClassNum(Klassenname), welche die Class eindeutig identifizieren, angegeben werden.

#### Get Characteristics

Gibt Informationen zu den Characteristics einer Class zurück.
Dazu müssen ClassType(Klassentyp) und ClassNum(Klassenname) angegeben werden.

**Anmerkung:** Nicht in Verwendung.

#### Change

Ermöglicht die Änderung der Beschreibung einer angegebenen Class.
Dazu müssen ClassType(Klassentyp), ClassNum(Klassenname), Description(alte Beschreibung), LanguIso(alte Iso-Sprachenrepräsentation),
DescriptionNew(neue Beschreibung) und LanguIsoNew(neue Iso-Sprachenrepräsentation) angegeben werden.

**Anmerkung:** Ändern aufgrund von serverseitigen Problemen nicht möglich.

#### Create

Ermöglicht das Erstellen einer neuen Class.
Dazu müssen ClassType(Klassentyp), ClassNum(Klassenname), LanguIso(Iso-Sprachenrepräsentation) und Description(Beschreibung) angegeben werden.

**Anmerkung:** Erstellen aufgrund von serverseitigen Problemen nicht möglich.

#### Delete

Ermöglicht das Löschen einer Class.
Dazu müssen ClassType(Klassentyp) und ClassNum(Klassenname) angegeben werden.

**Anmerkung:** Da nichts erstellt werden kann, sollte die Funktion nicht benutzt werden.


# Eingabeparameter

Zur vereinfachten Verwendung der Funktionen wurden zusätzlich Hilfskonstruktionen 
implementiert. Durch diese sind benötigte Werte eindeutig vorgegeben.

## Characteristic

- Get List
- Get Detail
- Get Long Text
- Add Long Text
- Remove Long Text
- Create
- Delete

### Get List

- GetList.Sign sign(Suchparameter Inklusive oder Exklusive)
- GetList.Options options(Optionen, z.B. größer, kleiner, gleich)
- string low(Suche von), string high(Suche bis, Standardwert = "_"(leer))

### Get Detail

- Characteristic characteristic(Characteristic welche ausgelesen werden soll)

### Get Long Text

- Characteristic characteristic(Characteristic von der der LongText ausgelesen werden soll)

### Add Long Text

- Characteristic characteristic(Characteristic an die ein Longtext angefügt werden soll)
- LongTextHelper.Format format(Format des LongTexts)
- string text(Inhalt LongText)

### Remove Long text

- Characteristic characteristic(Characteristic von der der LongText entfernt werden soll)

### Create

- Characteristic characteristic(Zu erstellende Characteristic)

### Delete

- Characteristic characteristic(Zu löschende Characteristic)

## Class

- Get List
- Get Detail
- Get Characteristics
- Change
- Create
- Delete

### Get List

- string classTypeNumber(Klassentyp), GetList.Sign sign(Suchparameter Inklusive oder Exklusive)
- GetList.Options options(Optionen, z.B. größer, kleiner, gleich)
- string low(Suche von), string high(Suche bis, Standardwert = "_"(leer))

### Get Detail

- string ClassType(Klassentyp), string ClassNumm(Klassenname)

### Get Characteristics

- string ClassType(Klassentyp), string ClassNumm(Klassenname)

### Change

- string ClassType(Klassentyp) 
- string ClassNumm(Klassenname)
- string Description(alte Beschreibung)
- string LanguIso(alte Iso-Sprachrepräsentation)
- string DescriptionNew(neue Beschreibung)
- string LanguIsoNew(neue Iso Sprachrepräsentation)

### Create

- string ClassType(Klassentyp) 
- string ClassNumm(Klassenname)
- string Description(Beschreibung)
- string LanguIso(Iso-Sprachrepräsentation)

### Delete

- string ClassType(Klassentyp)
- string ClassNumm(Klassenname)


# Beispiele

Die Oberfläche ist so gestaltet, dass keine falschen Daten eingegeben werden können.

Um zu beginnen, kann mit **List elements** eine Liste aller Objekte abgerufen werden. Anschließend kann
ein Objekt aus der Liste ausgewählt werden. Zu diesem Objekt können nun mit Hilfe von **Get Detail** zusätzliche
Informationen abgerufen werden oder es kann mit **Delete** gelöscht werden(Da kein Commit ausgeführt
wird verbleibt das Objekt dennoch im System). Mit **Create** kann ein neues Objekt erstellt werden, dazu muss ein Name
angegeben werden. Der Rest der benötigen Daten wird während der Erstellung vom Programm selbstständig hinzugefügt.
Diese Angaben gelten sowohl für **Characteristic** als auch für **Class**.

**Characteristic** bietet zusätzlich die Bearbeitungsfunktionen für **LongText**. Mt Hilfe dieser kann ein **LongText**
für die ausgewählte **Characteristic** abgerufen, gesetzt oder entfernt werden.

Mit **Change** kann die Beschreibung des ausgewählten Class-Objekts geändert werden. Hierfür muss eine neue Beschreibung eingegeben werden.

Am unteren Rand des Fensters werden Statusmeldungen des Programms ausgegeben(z.B. Fehlermeldungen, Erfolgsmeldungen, etc.).