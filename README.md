#Life is Strange save editor

**Warning:** Save editor is still in deep beta and can damage your save files or leads to unpredictable game behavior after load.

**BACKUP SAVE FILES** before using editor!

Save files are located in *"<My Documents folder>\My Games\Life Is Strange\Saves"* (LISSave[1-3].sav).

&nbsp;

####Save data structure is pretty complex and requires additional explanation.

**Level start states**

This list stores information about player progress at the beginning of each sublevel. Used when you choose sublevel to play at from main menu. For now this sections supported only as serialized .NET XML objects.

**Checkpoint level records**

First record (for example *E1_1A*) is main location package which defines current loading location. Other files are packages with additional models, textures, special effects, shadows, dialogs and so on. Actually, every file from *CookedPCConsoleFinal* folder, which relates to current location, should be in the list.

**Player progress**

Information about current player progress. Used when you choose to continue game from main menu.

**Active Facts**

Almost every your action in game is stored in save file: interactions with objects (look, read, take etc.), every chosen dialog option, shown tutorials, received SMS, made major and minor episode choices, new diary pages and characters and so on. Negative level means Fact is inactive, positive - Fact is active. You can activate some Fact once, then rewind and choose to not activate it. Thus Fact will have negative level. If there is no Fact in list at all, it means that you has never activated it. You need to try it yourself to understand how it works.

**File selects**

Every document you've ever read in game and document's pages you've seen. Data from this list is used in *"files"* diary tab.

&nbsp;

Application is not really user-friendly, just raw data editor. Post your feedback and i'll improve some features in further versions.
Hope save editor will helps someone or at least give a small impetus to modding community.
