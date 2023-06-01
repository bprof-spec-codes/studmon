# Csapat beosztás:

Acsai András: backend és frontend (mindenes)

Borossa Zoltán: frontend

Pongor Péter: backend -> frontend

Sörös Bence: frontend és csapatkapitány

## UserManual:

Program letöltése githubról: <https://github.com/bprof-spec-codes/studmon>

Backend: belépünk a studmon mappába, azon belül pedig studmon és elindítjuk studmon.sln-t egy visual studio-val. Beállítjuk, hogy a studmonBackend legyen a startup project, illetve kell egy add-migration-t és egy update-database-t futtatni a PackageManagerConsole-ban. Indítás után elérhető a szerverünk a  <http://localhost:5231>-on.

Frontend: Visual Studio Code-dal megnyitjuk a studmonClient mappát, ahol legelőszőr a terminálban kell egy „npm install”-t futtatni aztán pedig „ng serve”-t írni a terminálba és máris elindult a kliens oldalunk is ami elérhető a <http://localhost:4200> címen.

## User – pass kombinációk

Teszt tanár felhasználó

Id = "DFG234",

nev="Tóth Angéla",

Password= "asdasd",

Email=<toth.angela@gmail.com>

Teszt admin felhasználó

Id = "ADMIN1",

nev="Admin",

Password= "admin",

Email=<admin@gmail.com>



## API lista

Programunkhoz hét API pontot használunk.

API pontok:

- Auth
- HallgatoAPI
- OMToHMAPI
- OraAPI
- TanarAPI
- TeljesitmenyAPI
- TeremAPI

### Auth: 

- [HttpPost] Login([FromBody] LoginViewModel model) Logint teszi lehetővé.
- [HttpPut] InsertUser([FromBody] RegisterViewModel model) Regisztrációért felelős.
- [HttpGet] GetUserInfos() Felhasználó információit tudja szolgáltatni.
- [HttpDelete] DeleteMyself() Törli a felhasználót.

### HallgatoAPI:

- [HttpGet] GetAll() Összes hallgatót lekérdezi.
- [HttpGet("{id}")] Get(string id) Visszaad egy hallgatót.
- [HttpPost] Post([FromBody] Hallgato h) Ezzel hozunk létre hallgatót.
- [HttpDelete("{id}")] Delete(string id) Ezzel tudjuk törölni a hallgatót.
- [HttpPut] Put([FromBody] Hallgato h) Ezzel frissítjük a hallgatót.

### OMToHMAPI:
- [HttpGet] GetAll() Összes OraManyToHallgatoMany  lekérdezi.
- [HttpGet("{id}")] Get(string id) Visszaad egy  OraManyToHallgatoMany-t.
- [HttpPost] tPost([FromBody] OraManyToHallgatoMany value) Ezzel hozunk létre OraManyToHallgatoMany-t.
- [HttpDelete("{id}")] Delete(string id) Ezzel tudjuk törölni a OraManyToHallgatoMany-t.
- [HttpPut] Put([FromBody] OraManyToHallgatoMany value) Ezzel frissítjük a OraManyToHallgatoMany-t.

### OraAPI:

- [HttpGet] GetAll() Összes óra objektumot visszaadja.
- [HttpGet("{id}")] Get(string id) Egy adott órát visszaad ID alapján.
- [HttpPost] Post([FromBody] Ora h) Létrehoz egy óra objektumot.
- [HttpDelete("{id}")] Delete(string id) Töröl egy óra objektumot.
- [HttpPut] Put([FromBody] Ora h) Frissít egy óra objektumot.

### TanarAPI:

- [HttpGet] GetAll() Összes tanárt visszaadja.
- [HttpGet("{id}")] Get(string id) Egy tanárt visszaszolgáltat.
- [HttpPost] Post([FromBody] Tanar h) Létrehoz egy tanár objektumot.
- [HttpDelete("{id}")] Delete(string id) Töröl egy tanárt.
- [HttpPut] Put([FromBody] Tanar h) Frissít egy tanárt.

### TeljesitmenyAPI:

- [HttpGet] GetAll() Visszaadja az összes teljesítményt.
- [HttpGet("{id}")] Get(string id) Egy teljesítményt ad vissza.
- [HttpPost] Post([FromBody] Teljesitmeny h) Teljesítményt létrehoz.
- [HttpDelete("{id}")] Delete(string id) Töröl egy teljesítményt.
- [HttpPut] Put([FromBody] Teljesitmeny h) Frissít egy teljesítményt.

### TeremAPI:

- [HttpGet] GetAll() Összes termet visszaadja.
- [HttpGet("{id}")] Get(string id) Egy termet visszaad.
- [HttpPost] Post([FromBody] Terem h) Létrehoz egy termet.
- [HttpDelete("{id}")] Delete(string id) Töröl egy termet.
- [HttpPut] Put([FromBody] Terem h) Frissít egy termet.

## UI felület:

Regisztrációs felület:

![image](https://github.com/bprof-spec-codes/studmon/assets/91876468/4d4a6f39-6460-4e67-b94f-53063021a155)


Bejelntkezési felület: 

![image](https://github.com/bprof-spec-codes/studmon/assets/91876468/77dbd4ad-de72-4f45-81d0-2312c1efb4ff)


Bejelntkezve a felület, főoldal:
![image](https://github.com/bprof-spec-codes/studmon/assets/91876468/ff75027e-ccd5-464a-9f7f-e747c336d89b)


Tanárok felület:
![image](https://github.com/bprof-spec-codes/studmon/assets/91876468/6bbadb0f-fae5-43db-ba08-40552cf9e508)


Hallgató statisztika felület:
![image](https://github.com/bprof-spec-codes/studmon/assets/91876468/34d43ef6-4be9-4d9e-80b5-ebd7d3b8c794)


Tanórák lista felület:
![image](https://github.com/bprof-spec-codes/studmon/assets/91876468/077279ef-6155-4c4b-8ec9-77a87bb7356e)


Admin létrehozás:

Hallgatók:
![image](https://github.com/bprof-spec-codes/studmon/assets/91876468/0801d149-0a5a-4a66-892b-aaa572751ac0)

Órák:
![image](https://github.com/bprof-spec-codes/studmon/assets/91876468/7770dca2-d515-4c97-92ca-7e611b7bf5ea)

Termek:
![image](https://github.com/bprof-spec-codes/studmon/assets/91876468/8e6fb9fd-29af-4dcf-a0cc-9bb1dd301748)

Admin listák:

Hallgatók:
![image](https://github.com/bprof-spec-codes/studmon/assets/91876468/477f166c-a016-4e92-88b6-b56f70be12fc)

Órák:
![image](https://github.com/bprof-spec-codes/studmon/assets/91876468/de0ab5ff-4d36-410c-a5d4-bc11a7e3601e)

Termek:
![image](https://github.com/bprof-spec-codes/studmon/assets/91876468/4a8abc0f-6de4-42b0-afe5-7e4447f5f03f)






Probléma jegyzőkönyv:

