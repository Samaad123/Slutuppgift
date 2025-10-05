Trading System


Detta är ett enkelt byta-system där användare kan registrera sig, logga in, ladda upp objekt för byte och begära eller acceptera tradeförfrågningar. Alla användardata, objekt och tradeförfrågningar lagras i textfiler på datorn så att informationen sparas även om programmet stängs av.

Funktioner
1. Registrera konto

Användaren kan skapa ett konto genom att ange sin e-postadress och lösenord.

2. Logga in

Användaren kan logga in genom att ange sin e-postadress och sitt lösenord. Om rätt information anges loggas användaren in.

3. Ladda upp objekt

När användaren är inloggad kan de ladda upp objekt de vill byta. Objektet kan ha ett namn, en beskrivning och en ägarens e-postadress.

4. Begära trade

Användaren kan begära att byta sitt objekt mot någon annans objekt genom att ange vilket objekt de vill byta och vilket objekt de vill ta emot.

5. Visa tradeförfrågningar

Användare kan se alla tradeförfrågningar och acceptera eller neka förfrågningar.

6. Acceptera och neka tradeförfrågningar

Användaren som får en tradeförfrågan kan acceptera eller neka den.

7. Visa genomförda trades

Användaren kan se alla genomförda trades (både accepterade och nekade förfrågningar).

Användning

Starta programmet: Programmet startas genom att köra Program.cs. En meny visas där användaren kan välja olika alternativ (t.ex. registrera sig, logga in, ladda upp objekt, etc.).

Menyn i programmet:

1: Registrera konto

2: Logga in

3: Logga ut

4: Ladda upp objekt

5: Visa alla objekt

6: Visa mina objekt

7: Begär en trade

8: Visa alla tradeförfrågningar

9: Acceptera tradeförfrågan

10: Neka tradeförfrågan

11: Visa genomförda trades

0: Avsluta programmet

Implementeringsval
1. Designval:

Komposition: Jag har använt komposition för att skapa relationer mellan olika objekt. Till exempel, en TradeRequest innehåller både en User och en Item. Detta gör systemet modulärt och lätt att hantera.

Ingen arv: Jag har inte använt arv eftersom systemet inte kräver komplexa hierarkier. Varje objekt (User, Item, TradeRequest) är självständigt och hanterar sin egen data.

2. Val av lagring:

Textfiler: Jag har lagrat all data i textfiler (users.txt, items.txt, och trades.txt) för att hålla programmet enkelt. Det innebär att jag inte använder en databas och att filerna kan hanteras direkt av programmet.

3. Val av funktioner:

StreamWriter och StreamReader: För att läsa och skriva till textfiler använder jag dessa klasser. Det gör att jag kan lagra data mellan sessionerna utan att behöva externa databaser.

4. Val av undantagshantering:

Jag har hållit undantagshanteringen enkel. Jag kontrollerar att filer existerar innan jag försöker läsa eller skriva till dem.

Framtida Förbättringar

Säkrare lösenord: Jag kan förbättra säkerheten genom att hasha lösenorden istället för att lagra dem i klartext.

Grafiskt användargränssnitt (GUI): För att göra det enklare för användarna kan jag utveckla ett grafiskt gränssnitt (istället för enbart kommandoradsbaserat).

Databas: Om programmet växer kan jag byta till en databas för att hantera större mängder data på ett mer skalbart sätt.

Projektstruktur:

Program.cs – Huvudsaklig körlogik för programmet.

User.cs – Hanterar användardata (e-post, lösenord, objekt).

Item.cs – Representerar objekt som kan bytas.

TradeRequest.cs – Representerar en begäran om byte mellan användare.

Save.cs – Hanterar lagring och hämtning av data från textfiler.