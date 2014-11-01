using System;
using System.ComponentModel;
using System.Management;
using System.Collections;
using System.Globalization;

namespace Argon.WindowsXP.Network
{
    public class WmiNetworkAdapter: System.ComponentModel.Component {
        
        // Private property to hold the WMI namespace in which the class resides.
        private static string CreatedWmiNamespace = "root\\CimV2";
        
        // Private property to hold the name of WMI class which created this class.
        private static string CreatedClassName = "Win32_NetworkAdapter";
        
        // Private member variable to hold the ManagementScope which is used by the various methods.
        private static System.Management.ManagementScope statMgmtScope = null;
        
        private ManagementSystemProperties PrivateSystemProperties;
        
        // Underlying lateBound WMI object.
        private System.Management.ManagementObject PrivateLateBoundObject;
        
        // Member variable to store the 'automatic commit' behavior for the class.
        private bool AutoCommitProp;
        
        // Private variable to hold the embedded property representing the instance.
        private System.Management.ManagementBaseObject embeddedObj;
        
        // The current WMI object used
        private System.Management.ManagementBaseObject curObj;
        
        // Flag to indicate if the instance is an embedded object.
        private bool isEmbedded;
        
        // Below are different overloads of constructors to initialize an instance of the class with a WMI object.
        public WmiNetworkAdapter() {
            this.InitializeObject(null, null, null);
        }
        
        public WmiNetworkAdapter(string keyDeviceID) {
            this.InitializeObject(null, new System.Management.ManagementPath(WmiNetworkAdapter.ConstructPath(keyDeviceID)), null);
        }
        
        public WmiNetworkAdapter(System.Management.ManagementScope mgmtScope, string keyDeviceID) {
            this.InitializeObject(((System.Management.ManagementScope)(mgmtScope)), new System.Management.ManagementPath(WmiNetworkAdapter.ConstructPath(keyDeviceID)), null);
        }
        
        public WmiNetworkAdapter(System.Management.ManagementPath path, System.Management.ObjectGetOptions getOptions) {
            this.InitializeObject(null, path, getOptions);
        }
        
        public WmiNetworkAdapter(System.Management.ManagementScope mgmtScope, System.Management.ManagementPath path) {
            this.InitializeObject(mgmtScope, path, null);
        }
        
        public WmiNetworkAdapter(System.Management.ManagementPath path) {
            this.InitializeObject(null, path, null);
        }
        
        public WmiNetworkAdapter(System.Management.ManagementScope mgmtScope, System.Management.ManagementPath path, System.Management.ObjectGetOptions getOptions) {
            this.InitializeObject(mgmtScope, path, getOptions);
        }
        
        public WmiNetworkAdapter(System.Management.ManagementObject theObject) {
            Initialize();
            if ((CheckIfProperClass(theObject) == true)) {
                PrivateLateBoundObject = theObject;
                PrivateSystemProperties = new ManagementSystemProperties(PrivateLateBoundObject);
                curObj = PrivateLateBoundObject;
            }
            else {
                throw new System.ArgumentException("Class name does not match.");
            }
        }

        public WmiNetworkAdapter(System.Management.ManagementBaseObject theObject)
        {
            Initialize();
            if ((CheckIfProperClass(theObject) == true)) {
                embeddedObj = theObject;
                PrivateSystemProperties = new ManagementSystemProperties(theObject);
                curObj = embeddedObj;
                isEmbedded = true;
            }
            else {
                throw new System.ArgumentException("Class name does not match.");
            }
        }
        
        // Property returns the namespace of the WMI class.
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string OriginatingNamespace {
            get {
                return "root\\CimV2";
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ManagementClassName {
            get {
                string strRet = CreatedClassName;
                if ((curObj != null)) {
                    if ((curObj.ClassPath != null)) {
                        strRet = ((string)(curObj["__CLASS"]));
                        if (((strRet == null) 
                                    || (strRet == string.Empty))) {
                            strRet = CreatedClassName;
                        }
                    }
                }
                return strRet;
            }
        }
        
        // Property pointing to an embedded object to get System properties of the WMI object.
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ManagementSystemProperties SystemProperties {
            get {
                return PrivateSystemProperties;
            }
        }
        
        // Property returning the underlying lateBound object.
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public System.Management.ManagementBaseObject LateBoundObject {
            get {
                return curObj;
            }
        }
        
        // ManagementScope of the object.
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public System.Management.ManagementScope Scope {
            get {
                if ((isEmbedded == false)) {
                    return PrivateLateBoundObject.Scope;
                }
                else {
                    return null;
                }
            }
            set {
                if ((isEmbedded == false)) {
                    PrivateLateBoundObject.Scope = value;
                }
            }
        }
        
        // Property to show the commit behavior for the WMI object. If true, WMI object will be automatically saved after each property modification.(ie. Put() is called after modification of a property).
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool AutoCommit {
            get {
                return AutoCommitProp;
            }
            set {
                AutoCommitProp = value;
            }
        }
        
        // The ManagementPath of the underlying WMI object.
        [Browsable(true)]
        public System.Management.ManagementPath Path {
            get {
                if ((isEmbedded == false)) {
                    return PrivateLateBoundObject.Path;
                }
                else {
                    return null;
                }
            }
            set {
                if ((isEmbedded == false)) {
                    if ((CheckIfProperClass(null, value, null) != true)) {
                        throw new System.ArgumentException("Class name does not match.");
                    }
                    PrivateLateBoundObject.Path = value;
                }
            }
        }
        
        // Public static scope property which is used by the various methods.
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public static System.Management.ManagementScope StaticScope {
            get {
                return statMgmtScope;
            }
            set {
                statMgmtScope = value;
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("La proprietà AdapterType riflette il supporto di rete utilizzato. È possibile che" +
            " tale proprietà non sia applicabile a tutti i tipi di schede di rete elencate al" +
            "l\'interno di questa classe. Solo Windows NT.")]
        public string AdapterType {
            get {
                return ((string)(curObj["AdapterType"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsAdapterTypeIdNull {
            get {
                if ((curObj["AdapterTypeId"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"La proprietà AdapterTypeId riflette il tipo di rete utilizzato. Questa proprietà restituisce le stesse informazioni della proprietà AdapterType, tranne che per il fatto che le informazioni vengono restituite sotto forma di un valore intero identificato come segue: 
0 - Ethernet 802.3
1 - Token Ring 802.5
2 - FDDI (Fiber Distributed Data Interface)
3 - WAN (Wide Area Network)
4 - LocalTalk
5 - Ethernet con formato di intestazione DIX
6 - ARCNET
7 - ARCNET (878.2)
8 - ATM
9 - Wireless
10 - Wireless a infrarossi 
11 - Bpc
12 - CoWan
13 - 1394
Questa proprietà potrebbe non essere applicabile a tutti i tipi di schede di rete elencate in questa classe. Solo Windows NT.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public AdapterTypeIdValues AdapterTypeId {
            get {
                if ((curObj["AdapterTypeId"] == null)) {
                    return ((AdapterTypeIdValues)(System.Convert.ToInt32(14)));
                }
                return ((AdapterTypeIdValues)(System.Convert.ToInt32(curObj["AdapterTypeId"])));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsAutoSenseNull {
            get {
                if ((curObj["AutoSense"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Un valore booleano che indica se NetworkAdapter (la scheda di rete) sia in grado " +
            "di  individuare automaticamente la velocità o altre caratteristiche di comunicaz" +
            "ione dei supporti di rete collegati.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool AutoSense {
            get {
                if ((curObj["AutoSense"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["AutoSense"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsAvailabilityNull {
            get {
                if ((curObj["Availability"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"Indica la disponibilità e lo stato del dispositivo Device. Ad esempio, la proprietà Availability indica che il dispositivo è in funzione e sta utilizzando tutta l'energia  (valore=3), oppure si trova in stato di allerta (4), prova (5), degrado (10) o risparmio energia (valori da 13 a 15 e 17). Gli stati di risparmio energetico sono definiti come segue: 13 (""Risparmio energia - Sconosciuto"" indica che è noto che il dispositivo è in modalità risparmio energia, ma il suo stato esatto in tale modalità è sconosciuto; 14 (""Risparmio energia - Modalità basso consumo"" indica che il dispositivo è in modalità risparmio energia, ma continua a funzionare e potrebbe avere prestazioni rallentate; 15 (""Risparmio energia - Standby"") indica che il dispositivo non sta funzionando ma può essere riattivata completamente 'con rapidità'; e il valore 17 (""Risparmio energia - Avviso"") indica che il dispositivo è in uno stato di avviso, ma anche in modalità risparmio energia.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public AvailabilityValues Availability {
            get {
                if ((curObj["Availability"] == null)) {
                    return ((AvailabilityValues)(System.Convert.ToInt32(0)));
                }
                return ((AvailabilityValues)(System.Convert.ToInt32(curObj["Availability"])));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("La proprietà Caption è una breve descrizione testuale (una riga di testo) dell\'og" +
            "getto.")]
        public string Caption {
            get {
                return ((string)(curObj["Caption"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsConfigManagerErrorCodeNull {
            get {
                if ((curObj["ConfigManagerErrorCode"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Indica il codice di errore di Gestione configurazione Win32. Restituisce i valori" +
            " seguenti:  \n0      Dispositivo correttamente funzionante. \n1      Dispositivo n" +
            "on configurato in modo corretto. \n2      Impossibile caricare il driver per il d" +
            "ispositivo. \n3      Driver di dispositivo danneggiato oppure memoria o altre ris" +
            "orse insufficienti nel sistema. \n4      Dispositivo non correttamente funzionant" +
            "e. Driver di dispositivo o Registro di sistema danneggiato. \n5      Il driver pe" +
            "r il dispositivo richiede una risorsa non gestibile da Windows. \n6      La confi" +
            "gurazione di avvio del dispositivo è in conflitto con altri dispositivi. \n7     " +
            " Impossibile filtrare. \n8      Caricatore del driver mancante per il dispositivo" +
            ". \n9      Il dispositivo non funziona correttamente perché il firmware di contro" +
            "llo non riporta correttamente le risorse necessarie. \n10      Impossibile avviar" +
            "e il dispositivo. \n11      Errore del dispositivo. \n12      Risorse insufficient" +
            "i per il dispositivo. \n13      Impossibile verificare le risorse del dispositivo" +
            ". \n14      Il dispositivo può funzionare correttamente solo dopo il riavvio del " +
            "computer. \n15      Il dispositivo non funziona correttamente probabilmente a cau" +
            "sa di un problema di rienumerazione. \n16      Impossibile identificare tutte le " +
            "risorse utilizzate dal dispositivo. \n17      Il dispositivo richiede un tipo di " +
            "risorsa sconosciuto. \n18      Reinstallare i driver per questo dispositivo. \n19 " +
            "     Il Registro di sistema potrebbe essere danneggiato. \n20      Errore del car" +
            "icatore VxD. \n21      Errore di sistema. Provare a cambiare il driver del dispos" +
            "itivo. Se il problema persiste, consultare la documentazione dell\'hardware. Il d" +
            "ispositivo verrà rimosso da Windows. \n22      Dispositivo disabilitato. \n23     " +
            " Errore di sistema. Provare a cambiare il driver del dispositivo. Se il problema" +
            " persiste, consultare la documentazione dell\'hardware. \n24      Il dispositivo n" +
            "on esiste, non funziona correttamente o non sono stati installati tutti i driver" +
            ". \n25      Dispositivo ancora in fase di configurazione. \n26      Dispositivo an" +
            "cora in fase di configurazione. \n27      Configurazione del registro non valida " +
            "per il dispositivo. \n28      I driver del dispositivo non sono installati. \n29  " +
            "    Il dispositivo è stato disabilitato perché il firmware non ha assegnato le r" +
            "isorse necessarie. \n30      Il dispositivo utilizza una risorsa IRQ utilizzata d" +
            "a un altro dispositivo. \n31      Il dispositivo non funziona correttamente: impo" +
            "ssibile caricare i driver richiesti.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public ConfigManagerErrorCodeValues ConfigManagerErrorCode {
            get {
                if ((curObj["ConfigManagerErrorCode"] == null)) {
                    return ((ConfigManagerErrorCodeValues)(System.Convert.ToInt32(32)));
                }
                return ((ConfigManagerErrorCodeValues)(System.Convert.ToInt32(curObj["ConfigManagerErrorCode"])));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsConfigManagerUserConfigNull {
            get {
                if ((curObj["ConfigManagerUserConfig"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Indica se il dispositivo utilizza una configurazione definita dall\'utente.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool ConfigManagerUserConfig {
            get {
                if ((curObj["ConfigManagerUserConfig"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["ConfigManagerUserConfig"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"CreationClassName indica il nome della classe o sottoclasse utilizzata per la creazione di un'istanza. Quando viene utilizzata insieme con le altre proprietà chiave della classe, la proprietà consente l'identificazione univoca di tutte le istanze della classe e delle sue sottoclassi.")]
        public string CreationClassName {
            get {
                return ((string)(curObj["CreationClassName"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("La proprietà Description fornisce la descrizione testuale dell\'oggetto. ")]
        public string Description {
            get {
                return ((string)(curObj["Description"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("La proprietà DeviceID contiene una stringa che identifica in modo univoco la sche" +
            "da di rete rispetto ad altre periferiche presenti nel sistema.")]
        public string DeviceID {
            get {
                return ((string)(curObj["DeviceID"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsErrorClearedNull {
            get {
                if ((curObj["ErrorCleared"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("ErrorCleared è una proprietà booleana che indica l\'eliminazione dell\'errore ripor" +
            "tato in LastErrorCode.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool ErrorCleared {
            get {
                if ((curObj["ErrorCleared"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["ErrorCleared"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("ErrorDescription è una stringa in formato libero che contiene ulteriori informazi" +
            "oni sull\'errore registrato in LastErrorCode e su eventuali interventi di correzi" +
            "one.")]
        public string ErrorDescription {
            get {
                return ((string)(curObj["ErrorDescription"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("La proprietà GUID specifica l\'identificatore univoco globale per la connessione.")]
        public string GUID {
            get {
                return ((string)(curObj["GUID"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsIndexNull {
            get {
                if ((curObj["Index"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("La proprietà Index indica il numero di indice della scheda di rete, memorizzato n" +
            "el registro di sistema. \nEsempio: 0.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint Index {
            get {
                if ((curObj["Index"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["Index"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsInstallDateNull {
            get {
                if ((curObj["InstallDate"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("La proprietà InstallDate è un valore data/ora che indica la data di installazione" +
            " dell\'oggetto. L\'assenza del valore non indica la mancata installazione dell\'ogg" +
            "etto.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public System.DateTime InstallDate {
            get {
                if ((curObj["InstallDate"] != null)) {
                    return ToDateTime(((string)(curObj["InstallDate"])));
                }
                else {
                    return System.DateTime.MinValue;
                }
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsInstalledNull {
            get {
                if ((curObj["Installed"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"La proprietà Installed determina se la scheda di rete è installata nel sistema.
Valori: TRUE o FALSE. Il valore TRUE indica che la scheda di rete è installata.  
La proprietà Installed è stata dichiarata obsoleta.  Non è disponibile alcun valore sostitutivo.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool Installed {
            get {
                if ((curObj["Installed"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["Installed"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsInterfaceIndexNull {
            get {
                if ((curObj["InterfaceIndex"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("La proprietà InterfaceIndex contiene il valore di indice che identifica univocame" +
            "nte l\'interfaccia locale.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint InterfaceIndex {
            get {
                if ((curObj["InterfaceIndex"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["InterfaceIndex"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsLastErrorCodeNull {
            get {
                if ((curObj["LastErrorCode"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("LastErrorCode acquisisce l\'ultimo codice di errore riportato dal dispositivo logi" +
            "co.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint LastErrorCode {
            get {
                if ((curObj["LastErrorCode"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["LastErrorCode"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"La proprietà MACAddress indica l'indirizzo MAC (Media Access Control) per la scheda di rete in uso. Un indirizzo MAC è un numero univoco a 48 bit assegnato dal produttore alla scheda di rete. Tale indirizzo identifica in modo univoco la scheda di rete e viene utilizzato per il mapping delle comunicazioni di rete TCP/IP.")]
        public string MACAddress {
            get {
                return ((string)(curObj["MACAddress"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("La proprietà Manufacturer indica il nome del produttore della scheda di rete.\nEse" +
            "mpio: 3COM.")]
        public string Manufacturer {
            get {
                return ((string)(curObj["Manufacturer"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsMaxNumberControlledNull {
            get {
                if ((curObj["MaxNumberControlled"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("La proprietà MaxNumberControlled indica il numero massimo di porte indirizzabili " +
            "direttamente supportate dalla scheda di rete in uso. Utilizzare il valore 0 (zer" +
            "o) se tale numero non è noto.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint MaxNumberControlled {
            get {
                if ((curObj["MaxNumberControlled"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["MaxNumberControlled"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsMaxSpeedNull {
            get {
                if ((curObj["MaxSpeed"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("La velocità massima, in bit per secondo della scheda di rete.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public ulong MaxSpeed {
            get {
                if ((curObj["MaxSpeed"] == null)) {
                    return System.Convert.ToUInt64(0);
                }
                return ((ulong)(curObj["MaxSpeed"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("La proprietà Name definisce l\'etichetta che indica il nome dell\'oggetto. Quando è" +
            " sottoclassata, la proprietà Key può prevalere su di essa.")]
        public string Name {
            get {
                return ((string)(curObj["Name"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("La proprietà NetConnectionID specifica il nome della connessione di rete come vis" +
            "ualizzato nella cartella \'Connessioni di rete\'.")]
        public string NetConnectionID {
            get {
                return ((string)(curObj["NetConnectionID"]));
            }
            set {
                curObj["NetConnectionID"] = value;
                if (((isEmbedded == false) 
                            && (AutoCommitProp == true))) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsNetConnectionStatusNull {
            get {
                if ((curObj["NetConnectionStatus"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"NetConnectionStatus è una stringa che indica lo stato di connessione della scheda di rete. Il valore della proprietà deve essere interpretato nel modo seguente:
0 - Disconnesso
1 - Connessione a
2 - Connesso
3 - Disconnessione
4 - Nessun elemento hardware rilevato 
5 - Hardware disabilitato
6 - Malfunzionamento hardware 
7 - Supporto disconnesso 
8 - Autenticazione in corso 
9 - Autenticazione completata
10 - Autenticazione non riuscita
11 - Indirizzo non valido
12 - Sono richieste credenziali
.. - Altro - Per valori interi diversi da quelli elencati precedentemente, fare riferimento alla documentazione dei codici di errore di Win32.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public ushort NetConnectionStatus {
            get {
                if ((curObj["NetConnectionStatus"] == null)) {
                    return System.Convert.ToUInt16(0);
                }
                return ((ushort)(curObj["NetConnectionStatus"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsNetEnabledNull {
            get {
                if ((curObj["NetEnabled"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("La proprietà NetEnabled indica se la connessione di rete è abilitata o meno.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool NetEnabled {
            get {
                if ((curObj["NetEnabled"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["NetEnabled"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Matrice di stringhe che indica gli indirizzi di rete per l\'adattatore.")]
        public string[] NetworkAddresses {
            get {
                return ((string[])(curObj["NetworkAddresses"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"PermanentAddress definisce l'indirizzo di rete codificato all'interno dell'hardware della scheda. Tale indirizzo può essere modificato attraverso un aggiornamento del firmware o la configurazione software. In tal caso, questo campo deve essere aggiornato quando viene effettuata la modifica. PermanentAddress deve essere lasciato vuoto se non è disponibile alcun indirizzo codificato nell'hardware della scheda di rete.")]
        public string PermanentAddress {
            get {
                return ((string)(curObj["PermanentAddress"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsPhysicalAdapterNull {
            get {
                if ((curObj["PhysicalAdapter"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("La proprietà PhysicalAdapter indica se la scheda è una scheda fisica o logica.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool PhysicalAdapter {
            get {
                if ((curObj["PhysicalAdapter"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["PhysicalAdapter"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Indica l\'ID Plug and Play per Win32 del dispositivo logico. Ad esempio, *PNP030b")]
        public string PNPDeviceID {
            get {
                return ((string)(curObj["PNPDeviceID"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"Indica le caratteristiche alimentazione della dispositivo logico. I valori di matrice, 0=""Sconosciuto"", 1=""Non supportato"" e 2=""Disattivato"" sono di chiara interpretazione. Il valore, 3=""Abilitato"" indica che le funzionalità di gestione alimentazione sono al momento abilitate, ma la combinazione esatta di funzionalità è sconosciuta o non disponibile. ""Modalità di risparmio energia attivate automaticamente"" (4) indica che un dispositivo è in grado di cambiare il proprio stato di alimentazione sulla base dell'utilizzo o altri criteri. ""Stato alimentazione impostabile"" (5) indica che il metodo SetPowerState è supportato. ""Ciclo alimentazione supportato"" (6) indica che il metodo SetPowerState può essere invocato con la variabile di input PowerState impostata a 5 (""Ciclo alimentazione""). ""Accensione programmata supportata"" (7) indica che il metodo SetPowerState può essere invocato con la variabile di input PowerState impostata a 5 (""Ciclo alimentazione"") e il parametro Ora impostato a una specifica data e ora, o intervallo, per l'accensione.")]
        public PowerManagementCapabilitiesValues[] PowerManagementCapabilities {
            get {
                System.Array arrEnumVals = ((System.Array)(curObj["PowerManagementCapabilities"]));
                PowerManagementCapabilitiesValues[] enumToRet = new PowerManagementCapabilitiesValues[arrEnumVals.Length];
                int counter = 0;
                for (counter = 0; (counter < arrEnumVals.Length); counter = (counter + 1)) {
                    enumToRet[counter] = ((PowerManagementCapabilitiesValues)(System.Convert.ToInt32(arrEnumVals.GetValue(counter))));
                }
                return enumToRet;
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsPowerManagementSupportedNull {
            get {
                if ((curObj["PowerManagementSupported"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"Valore booleano che indica che è possibile gestire l'alimentazione del dispositivo, ad esempio, attivandone le funzioni di risparmio energetico. Questo valore booleano non indica se le caratteristiche di risparmio energetico sono attivate o, se sono attivate, quali funzioni sono supportate. Per queste informazioni fare riferimento alla matrice PowerManagementCapabilities. Se il valore booleano è false, il valore intero 1 per la stringa ""Non supportato"", deve essere l'unica voce presente nella matrice PowerManagementCapabilities.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool PowerManagementSupported {
            get {
                if ((curObj["PowerManagementSupported"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["PowerManagementSupported"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("La proprietà ProductName indica il nome del prodotto della scheda di rete.\nEsempi" +
            "o: Fast EtherLink XL")]
        public string ProductName {
            get {
                return ((string)(curObj["ProductName"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("La proprietà ServiceName indica il nome di servizio della scheda di rete. Tale no" +
            "me è in genere abbreviato rispetto al nome completo. \nEsempio: Elnkii.")]
        public string ServiceName {
            get {
                return ((string)(curObj["ServiceName"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsSpeedNull {
            get {
                if ((curObj["Speed"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Stima della larghezza di banda corrente in bit al secondo. Per le uscite con larg" +
            "hezza di banda variabile e per quelle non calcolabili con precisione, la proprie" +
            "tà dovrebbe contenere la larghezza di banda nominale.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public ulong Speed {
            get {
                if ((curObj["Speed"] == null)) {
                    return System.Convert.ToUInt64(0);
                }
                return ((ulong)(curObj["Speed"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"È una stringa che indica lo stato corrente dell'oggetto. È possibile definire diversi stati, operativi e non operativi. Gli stati operativi sono ""OK"", ""Danneggiato"" e ""Errore prev."". ""Errore prev."" indica che un elemento, che funziona correttamente, potrebbe smettere di funzionare nell'immediato futuro, ad esempio un'unità abilitata SMART. È inoltre possibile specificare stati non operativi, vale a dire ""Errore"", ""Avvio in corso"", ""Arresto in corso"" e ""Servizio"". Lo stato ""Servizio"" può verificarsi durante la riconfigurazione del mirroring di un disco, il ricaricamento di un elenco di autorizzazioni utente e altre attività amministrative. Non tutte le attività amministrative sono in rete, ma l'elemento gestito non è né OK, né in uno degli altri stati.")]
        public string Status {
            get {
                return ((string)(curObj["Status"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsStatusInfoNull {
            get {
                if ((curObj["StatusInfo"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"StatusInfo è una stringa che indica se il dispositivo logico si trova in uno stato abilitato (valore = 3), disabilitato (valore = 4), in un altro stato (1) o in uno stato sconosciuto (2). Se tale proprietà non è applicabile alla dispositivo logico, dovrebbe essere utilizzato il valore 5 (""Non applicabile"").")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public StatusInfoValues StatusInfo {
            get {
                if ((curObj["StatusInfo"] == null)) {
                    return ((StatusInfoValues)(System.Convert.ToInt32(0)));
                }
                return ((StatusInfoValues)(System.Convert.ToInt32(curObj["StatusInfo"])));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Il nome della classe di creazione del sistema dell\'ambito.")]
        public string SystemCreationClassName {
            get {
                return ((string)(curObj["SystemCreationClassName"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Il nome del sistema dell\'ambito.")]
        public string SystemName {
            get {
                return ((string)(curObj["SystemName"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsTimeOfLastResetNull {
            get {
                if ((curObj["TimeOfLastReset"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("La proprietà TimeOfLastReset indica la data dell\'ultimo ripristino della scheda d" +
            "i rete.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public System.DateTime TimeOfLastReset {
            get {
                if ((curObj["TimeOfLastReset"] != null)) {
                    return ToDateTime(((string)(curObj["TimeOfLastReset"])));
                }
                else {
                    return System.DateTime.MinValue;
                }
            }
        }
        
        private bool CheckIfProperClass(System.Management.ManagementScope mgmtScope, System.Management.ManagementPath path, System.Management.ObjectGetOptions OptionsParam) {
            if (((path != null) 
                        && (string.Compare(path.ClassName, this.ManagementClassName, true, System.Globalization.CultureInfo.InvariantCulture) == 0))) {
                return true;
            }
            else {
                return CheckIfProperClass(new System.Management.ManagementObject(mgmtScope, path, OptionsParam));
            }
        }
        
        private bool CheckIfProperClass(System.Management.ManagementBaseObject theObj) {
            if (((theObj != null) 
                        && (string.Compare(((string)(theObj["__CLASS"])), this.ManagementClassName, true, System.Globalization.CultureInfo.InvariantCulture) == 0))) {
                return true;
            }
            else {
                System.Array parentClasses = ((System.Array)(theObj["__DERIVATION"]));
                if ((parentClasses != null)) {
                    int count = 0;
                    for (count = 0; (count < parentClasses.Length); count = (count + 1)) {
                        if ((string.Compare(((string)(parentClasses.GetValue(count))), this.ManagementClassName, true, System.Globalization.CultureInfo.InvariantCulture) == 0)) {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        
        private bool ShouldSerializeAdapterTypeId() {
            if ((this.IsAdapterTypeIdNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeAutoSense() {
            if ((this.IsAutoSenseNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeAvailability() {
            if ((this.IsAvailabilityNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeConfigManagerErrorCode() {
            if ((this.IsConfigManagerErrorCodeNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeConfigManagerUserConfig() {
            if ((this.IsConfigManagerUserConfigNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeErrorCleared() {
            if ((this.IsErrorClearedNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeIndex() {
            if ((this.IsIndexNull == false)) {
                return true;
            }
            return false;
        }
        
        // Converts a given datetime in DMTF format to System.DateTime object.
        static System.DateTime ToDateTime(string dmtfDate) {
            System.DateTime initializer = System.DateTime.MinValue;
            int year = initializer.Year;
            int month = initializer.Month;
            int day = initializer.Day;
            int hour = initializer.Hour;
            int minute = initializer.Minute;
            int second = initializer.Second;
            long ticks = 0;
            string dmtf = dmtfDate;
            System.DateTime datetime = System.DateTime.MinValue;
            string tempString = string.Empty;
            if ((dmtf == null)) {
                throw new System.ArgumentOutOfRangeException();
            }
            if ((dmtf.Length == 0)) {
                throw new System.ArgumentOutOfRangeException();
            }
            if ((dmtf.Length != 25)) {
                throw new System.ArgumentOutOfRangeException();
            }
            try {
                tempString = dmtf.Substring(0, 4);
                if (("****" != tempString)) {
                    year = int.Parse(tempString);
                }
                tempString = dmtf.Substring(4, 2);
                if (("**" != tempString)) {
                    month = int.Parse(tempString);
                }
                tempString = dmtf.Substring(6, 2);
                if (("**" != tempString)) {
                    day = int.Parse(tempString);
                }
                tempString = dmtf.Substring(8, 2);
                if (("**" != tempString)) {
                    hour = int.Parse(tempString);
                }
                tempString = dmtf.Substring(10, 2);
                if (("**" != tempString)) {
                    minute = int.Parse(tempString);
                }
                tempString = dmtf.Substring(12, 2);
                if (("**" != tempString)) {
                    second = int.Parse(tempString);
                }
                tempString = dmtf.Substring(15, 6);
                if (("******" != tempString)) {
                    ticks = (long.Parse(tempString) * ((long)((System.TimeSpan.TicksPerMillisecond / 1000))));
                }
                if (((((((((year < 0) 
                            || (month < 0)) 
                            || (day < 0)) 
                            || (hour < 0)) 
                            || (minute < 0)) 
                            || (minute < 0)) 
                            || (second < 0)) 
                            || (ticks < 0))) {
                    throw new System.ArgumentOutOfRangeException();
                }
            }
            catch (System.Exception e) {
                throw new System.ArgumentOutOfRangeException(null, e.Message);
            }
            datetime = new System.DateTime(year, month, day, hour, minute, second, 0);
            datetime = datetime.AddTicks(ticks);
            System.TimeSpan tickOffset = System.TimeZone.CurrentTimeZone.GetUtcOffset(datetime);
            int UTCOffset = 0;
            int OffsetToBeAdjusted = 0;
            long OffsetMins = ((long)((tickOffset.Ticks / System.TimeSpan.TicksPerMinute)));
            tempString = dmtf.Substring(22, 3);
            if ((tempString != "******")) {
                tempString = dmtf.Substring(21, 4);
                try {
                    UTCOffset = int.Parse(tempString);
                }
                catch (System.Exception e) {
                    throw new System.ArgumentOutOfRangeException(null, e.Message);
                }
                OffsetToBeAdjusted = ((int)((OffsetMins - UTCOffset)));
                datetime = datetime.AddMinutes(((double)(OffsetToBeAdjusted)));
            }
            return datetime;
        }
        
        // Converts a given System.DateTime object to DMTF datetime format.
        static string ToDmtfDateTime(System.DateTime date) {
            string utcString = string.Empty;
            System.TimeSpan tickOffset = System.TimeZone.CurrentTimeZone.GetUtcOffset(date);
            long OffsetMins = ((long)((tickOffset.Ticks / System.TimeSpan.TicksPerMinute)));
            if ((System.Math.Abs(OffsetMins) > 999)) {
                date = date.ToUniversalTime();
                utcString = "+000";
            }
            else {
                if ((tickOffset.Ticks >= 0)) {
                    utcString = string.Concat("+", ((System.Int64 )((tickOffset.Ticks / System.TimeSpan.TicksPerMinute))).ToString().PadLeft(3, '0'));
                }
                else {
                    string strTemp = ((System.Int64 )(OffsetMins)).ToString();
                    utcString = string.Concat("-", strTemp.Substring(1, (strTemp.Length - 1)).PadLeft(3, '0'));
                }
            }
            string dmtfDateTime = ((System.Int32 )(date.Year)).ToString().PadLeft(4, '0');
            dmtfDateTime = string.Concat(dmtfDateTime, ((System.Int32 )(date.Month)).ToString().PadLeft(2, '0'));
            dmtfDateTime = string.Concat(dmtfDateTime, ((System.Int32 )(date.Day)).ToString().PadLeft(2, '0'));
            dmtfDateTime = string.Concat(dmtfDateTime, ((System.Int32 )(date.Hour)).ToString().PadLeft(2, '0'));
            dmtfDateTime = string.Concat(dmtfDateTime, ((System.Int32 )(date.Minute)).ToString().PadLeft(2, '0'));
            dmtfDateTime = string.Concat(dmtfDateTime, ((System.Int32 )(date.Second)).ToString().PadLeft(2, '0'));
            dmtfDateTime = string.Concat(dmtfDateTime, ".");
            System.DateTime dtTemp = new System.DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second, 0);
            long microsec = ((long)((((date.Ticks - dtTemp.Ticks) 
                        * 1000) 
                        / System.TimeSpan.TicksPerMillisecond)));
            string strMicrosec = ((System.Int64 )(microsec)).ToString();
            if ((strMicrosec.Length > 6)) {
                strMicrosec = strMicrosec.Substring(0, 6);
            }
            dmtfDateTime = string.Concat(dmtfDateTime, strMicrosec.PadLeft(6, '0'));
            dmtfDateTime = string.Concat(dmtfDateTime, utcString);
            return dmtfDateTime;
        }
        
        private bool ShouldSerializeInstallDate() {
            if ((this.IsInstallDateNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeInstalled() {
            if ((this.IsInstalledNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeInterfaceIndex() {
            if ((this.IsInterfaceIndexNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeLastErrorCode() {
            if ((this.IsLastErrorCodeNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeMaxNumberControlled() {
            if ((this.IsMaxNumberControlledNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeMaxSpeed() {
            if ((this.IsMaxSpeedNull == false)) {
                return true;
            }
            return false;
        }
        
        private void ResetNetConnectionID() {
            curObj["NetConnectionID"] = null;
            if (((isEmbedded == false) 
                        && (AutoCommitProp == true))) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeNetConnectionStatus() {
            if ((this.IsNetConnectionStatusNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeNetEnabled() {
            if ((this.IsNetEnabledNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializePhysicalAdapter() {
            if ((this.IsPhysicalAdapterNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializePowerManagementSupported() {
            if ((this.IsPowerManagementSupportedNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeSpeed() {
            if ((this.IsSpeedNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeStatusInfo() {
            if ((this.IsStatusInfoNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeTimeOfLastReset() {
            if ((this.IsTimeOfLastResetNull == false)) {
                return true;
            }
            return false;
        }
        
        [Browsable(true)]
        public void CommitObject() {
            if ((isEmbedded == false)) {
                PrivateLateBoundObject.Put();
            }
        }
        
        [Browsable(true)]
        public void CommitObject(System.Management.PutOptions putOptions) {
            if ((isEmbedded == false)) {
                PrivateLateBoundObject.Put(putOptions);
            }
        }
        
        private void Initialize() {
            AutoCommitProp = true;
            isEmbedded = false;
        }
        
        private static string ConstructPath(string keyDeviceID) {
            string strPath = "root\\CimV2:Win32_NetworkAdapter";
            strPath = string.Concat(strPath, string.Concat(".DeviceID=", string.Concat("\"", string.Concat(keyDeviceID, "\""))));
            return strPath;
        }
        
        private void InitializeObject(System.Management.ManagementScope mgmtScope, System.Management.ManagementPath path, System.Management.ObjectGetOptions getOptions) {
            Initialize();
            if ((path != null)) {
                if ((CheckIfProperClass(mgmtScope, path, getOptions) != true)) {
                    throw new System.ArgumentException("Class name does not match.");
                }
            }
            PrivateLateBoundObject = new System.Management.ManagementObject(mgmtScope, path, getOptions);
            PrivateSystemProperties = new ManagementSystemProperties(PrivateLateBoundObject);
            curObj = PrivateLateBoundObject;
        }
        
        // Different overloads of GetInstances() help in enumerating instances of the WMI class.
        public static NetworkAdapterCollection GetInstances() {
            return GetInstances(null, null, null);
        }
        
        public static NetworkAdapterCollection GetInstances(string condition) {
            return GetInstances(null, condition, null);
        }
        
        public static NetworkAdapterCollection GetInstances(System.String [] selectedProperties) {
            return GetInstances(null, null, selectedProperties);
        }
        
        public static NetworkAdapterCollection GetInstances(string condition, System.String [] selectedProperties) {
            return GetInstances(null, condition, selectedProperties);
        }
        
        public static NetworkAdapterCollection GetInstances(System.Management.ManagementScope mgmtScope, System.Management.EnumerationOptions enumOptions) {
            if ((mgmtScope == null)) {
                if ((statMgmtScope == null)) {
                    mgmtScope = new System.Management.ManagementScope();
                    mgmtScope.Path.NamespacePath = "root\\CimV2";
                }
                else {
                    mgmtScope = statMgmtScope;
                }
            }
            System.Management.ManagementPath pathObj = new System.Management.ManagementPath();
            pathObj.ClassName = "Win32_NetworkAdapter";
            pathObj.NamespacePath = "root\\CimV2";
            System.Management.ManagementClass clsObject = new System.Management.ManagementClass(mgmtScope, pathObj, null);
            if ((enumOptions == null)) {
                enumOptions = new System.Management.EnumerationOptions();
                enumOptions.EnsureLocatable = true;
            }
            return new NetworkAdapterCollection(clsObject.GetInstances(enumOptions));
        }
        
        public static NetworkAdapterCollection GetInstances(System.Management.ManagementScope mgmtScope, string condition) {
            return GetInstances(mgmtScope, condition, null);
        }
        
        public static NetworkAdapterCollection GetInstances(System.Management.ManagementScope mgmtScope, System.String [] selectedProperties) {
            return GetInstances(mgmtScope, null, selectedProperties);
        }
        
        public static NetworkAdapterCollection GetInstances(System.Management.ManagementScope mgmtScope, string condition, System.String [] selectedProperties) {
            if ((mgmtScope == null)) {
                if ((statMgmtScope == null)) {
                    mgmtScope = new System.Management.ManagementScope();
                    mgmtScope.Path.NamespacePath = "root\\CimV2";
                }
                else {
                    mgmtScope = statMgmtScope;
                }
            }
            System.Management.ManagementObjectSearcher ObjectSearcher = new System.Management.ManagementObjectSearcher(mgmtScope, new SelectQuery("Win32_NetworkAdapter", condition, selectedProperties));
            System.Management.EnumerationOptions enumOptions = new System.Management.EnumerationOptions();
            enumOptions.EnsureLocatable = true;
            ObjectSearcher.Options = enumOptions;
            return new NetworkAdapterCollection(ObjectSearcher.Get());
        }
        
        [Browsable(true)]
        public static WmiNetworkAdapter CreateInstance()
        {
            System.Management.ManagementScope mgmtScope = null;
            if ((statMgmtScope == null)) {
                mgmtScope = new System.Management.ManagementScope();
                mgmtScope.Path.NamespacePath = CreatedWmiNamespace;
            }
            else {
                mgmtScope = statMgmtScope;
            }
            System.Management.ManagementPath mgmtPath = new System.Management.ManagementPath(CreatedClassName);
            System.Management.ManagementClass tmpMgmtClass = new System.Management.ManagementClass(mgmtScope, mgmtPath, null);
            return new WmiNetworkAdapter(tmpMgmtClass.CreateInstance());
        }
        
        [Browsable(true)]
        public void Delete() {
            PrivateLateBoundObject.Delete();
        }
        
        public uint Disable() {
            if ((isEmbedded == false)) {
                System.Management.ManagementBaseObject inParams = null;                               
                System.Management.ManagementBaseObject outParams = PrivateLateBoundObject.InvokeMethod( "Disable", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public uint Enable() {
            if ((isEmbedded == false)) {
                System.Management.ManagementBaseObject inParams = null;
                System.Management.ManagementBaseObject outParams = PrivateLateBoundObject.InvokeMethod("Enable", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public uint Reset() {
            if ((isEmbedded == false)) {
                System.Management.ManagementBaseObject inParams = null;
                System.Management.ManagementBaseObject outParams = PrivateLateBoundObject.InvokeMethod("Reset", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public uint SetPowerState(ushort PowerState, System.DateTime Time) {
            if ((isEmbedded == false)) {
                System.Management.ManagementBaseObject inParams = null;
                inParams = PrivateLateBoundObject.GetMethodParameters("SetPowerState");
                inParams["PowerState"] = ((System.UInt16 )(PowerState));
                inParams["Time"] = ToDmtfDateTime(((System.DateTime)(Time)));
                System.Management.ManagementBaseObject outParams = PrivateLateBoundObject.InvokeMethod("SetPowerState", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public enum AdapterTypeIdValues {
            
            Ethernet_802_3 = 0,
            
            Token_Ring_802_5 = 1,
            
            FDDI_Fiber_Distributed_Data_Interface_ = 2,
            
            WAN_Wide_Area_Network_ = 3,
            
            LocalTalk = 4,
            
            Ethernet_con_formato_di_intestazione_DIX = 5,
            
            ARCNET = 6,
            
            ARCNET_878_2_ = 7,
            
            ATM = 8,
            
            Wireless = 9,
            
            Wireless_a_infrarossi = 10,
            
            Bpc = 11,
            
            CoWan = 12,
            
            Val_1394 = 13,
            
            NULL_ENUM_VALUE = 14,
        }
        
        public enum AvailabilityValues {
            
            Altro = 1,
            
            Sconosciuto = 2,
            
            In_esecuzione_Consumo_massimo = 3,
            
            Attenzione = 4,
            
            In_fase_di_test = 5,
            
            Non_applicabile = 6,
            
            Spento = 7,
            
            Offline = 8,
            
            Fuori_servizio = 9,
            
            Danneggiato = 10,
            
            Non_installato = 11,
            
            Errore_di_installazione = 12,
            
            Risparmio_energia_Sconosciuto = 13,
            
            Risparmio_energia_Modalità_basso_consumo = 14,
            
            Risparmio_energia_Standby = 15,
            
            Ciclo_alimentazione = 16,
            
            Risparmio_energia_Avviso = 17,
            
            Sospeso = 18,
            
            Non_pronto = 19,
            
            Non_configurata = 20,
            
            Inattivo = 21,
            
            NULL_ENUM_VALUE = 0,
        }
        
        public enum ConfigManagerErrorCodeValues {
            
            Il_dispositivo_funziona_correttamente_ = 0,
            
            Il_dispositivo_non_è_configurata_correttamente_ = 1,
            
            Impossibile_caricare_il_driver_del_dispositivo_ = 2,
            
            Il_driver_del_dispositivo_è_danneggiato_oppure_la_memoria_o_altre_risorse_del_sistema_non_sono_sufficienti_ = 3,
            
            Il_dispositivo_non_funziona_correttamente_È_possibile_che_uno_dei_driver_o_il_registro_di_sistema_sia_danneggiato_ = 4,
            
            Il_driver_del_dispositivo_richiede_una_risorsa_non_gestibile_da_Windows_ = 5,
            
            La_configurazione_di_avvio_del_dispositivo_è_in_conflitto_con_altri_dispositivi_ = 6,
            
            Impossibile_eseguire_il_filtro_ = 7,
            
            Il_caricatore_del_driver_di_dispositivo_è_assente_ = 8,
            
            Il_dispositivo_non_funziona_correttamente_perché_il_firmware_di_controllo_non_riporta_correttamente_le_risorse_necessarie_ = 9,
            
            Impossibile_avviare_questo_dispositivo_ = 10,
            
            Errore_della_dispositivo_ = 11,
            
            Risorse_insufficienti_per_il_dispositivo_ = 12,
            
            Impossibile_verificare_le_risorse_del_dispositivo_ = 13,
            
            Il_dispositivo_riprenderà_a_funzionare_correttamente_al_riavvio_del_computer_ = 14,
            
            Il_dispositivo_non_funziona_correttamente_Causa_possibile_problema_di_rienumerazione_ = 15,
            
            Impossibile_identificare_tutte_le_risorse_utilizzate_dal_dispositivo_ = 16,
            
            Il_dispositivo_richiede_un_tipo_di_risorsa_sconosciuto_ = 17,
            
            Reinstallare_i_driver_per_questo_dispositivo_ = 18,
            
            Errore_del_caricatore_VXD_ = 19,
            
            Il_Registro_di_sistema_potrebbe_essere_danneggiato_ = 20,
            
            Errore_di_sistema_Cambiare_il_driver_del_dispositivo_Se_il_problema_non_viene_risolto_consultare_la_documentazione_dell_hardware_Il_dispositivo_verrà_rimosso_da_Windows_ = 21,
            
            Il_dispositivo_è_disattivato_ = 22,
            
            Errore_di_sistema_Cambiare_il_driver_del_dispositivo_Se_il_problema_non_viene_risolto_consultare_la_documentazione_dell_hardware_ = 23,
            
            Il_dispositivo_non_esiste_non_funziona_correttamente_o_l_installazione_dei_driver_non_è_completa_ = 24,
            
            Il_dispositivo_è_in_fase_di_configurazione_ = 25,
            
            Il_dispositivo_è_in_fase_di_configurazione_0 = 26,
            
            Configurazione_non_valida_del_registro_del_dispositivo_ = 27,
            
            I_driver_del_dispositivo_non_sono_installati_ = 28,
            
            Il_dispositivo_è_stata_disattivato_perché_il_firmware_non_ha_assegnato_le_risorse_necessarie_ = 29,
            
            La_risorsa_IRQ_del_dispositivo_è_già_in_uso_ = 30,
            
            Il_dispositivo_non_funziona_correttamente_impossibile_caricare_i_driver_richiesti_ = 31,
            
            NULL_ENUM_VALUE = 32,
        }
        
        public enum PowerManagementCapabilitiesValues {
            
            Sconosciuto = 0,
            
            Non_supportato = 1,
            
            Disattivato = 2,
            
            Attivato = 3,
            
            Modalità_di_risparmio_energia_attivate_automaticamente = 4,
            
            Stato_alimentazione_impostabile = 5,
            
            Ciclo_alimentazione_supportato = 6,
            
            Accensione_programmata_supportata = 7,
            
            NULL_ENUM_VALUE = 8,
        }
        
        public enum StatusInfoValues {
            
            Altro = 1,
            
            Sconosciuto = 2,
            
            Abilitato = 3,
            
            Disabilitato = 4,
            
            Non_applicabile = 5,
            
            NULL_ENUM_VALUE = 0,
        }
        
        // Enumerator implementation for enumerating instances of the class.
        public class NetworkAdapterCollection : object, ICollection {
            
            private ManagementObjectCollection privColObj;
            
            public NetworkAdapterCollection(ManagementObjectCollection objCollection) {
                privColObj = objCollection;
            }
            
            public virtual int Count {
                get {
                    return privColObj.Count;
                }
            }
            
            public virtual bool IsSynchronized {
                get {
                    return privColObj.IsSynchronized;
                }
            }
            
            public virtual object SyncRoot {
                get {
                    return this;
                }
            }
            
            public virtual void CopyTo(System.Array array, int index) {
                privColObj.CopyTo(array, index);
                int nCtr;
                for (nCtr = 0; (nCtr < array.Length); nCtr = (nCtr + 1)) {
                    array.SetValue(new WmiNetworkAdapter(((System.Management.ManagementObject)(array.GetValue(nCtr)))), nCtr);
                }
            }
            
            public virtual System.Collections.IEnumerator GetEnumerator() {
                return new NetworkAdapterEnumerator(privColObj.GetEnumerator());
            }
            
            public class NetworkAdapterEnumerator : object, System.Collections.IEnumerator {
                
                private ManagementObjectCollection.ManagementObjectEnumerator privObjEnum;
                
                public NetworkAdapterEnumerator(ManagementObjectCollection.ManagementObjectEnumerator objEnum) {
                    privObjEnum = objEnum;
                }
                
                public virtual object Current {
                    get {
                        return new WmiNetworkAdapter(((System.Management.ManagementObject)(privObjEnum.Current)));
                    }
                }
                
                public virtual bool MoveNext() {
                    return privObjEnum.MoveNext();
                }
                
                public virtual void Reset() {
                    privObjEnum.Reset();
                }
            }
        }
        
        // TypeConverter to handle null values for ValueType properties
        public class WMIValueTypeConverter : TypeConverter {
            
            private TypeConverter baseConverter;
            
            private System.Type baseType;
            
            public WMIValueTypeConverter(System.Type inBaseType) {
                baseConverter = TypeDescriptor.GetConverter(inBaseType);
                baseType = inBaseType;
            }
            
            public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type srcType) {
                return baseConverter.CanConvertFrom(context, srcType);
            }
            
            public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) {
                return baseConverter.CanConvertTo(context, destinationType);
            }
            
            public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) {
                return baseConverter.ConvertFrom(context, culture, value);
            }
            
            public override object CreateInstance(System.ComponentModel.ITypeDescriptorContext context, System.Collections.IDictionary dictionary) {
                return baseConverter.CreateInstance(context, dictionary);
            }
            
            public override bool GetCreateInstanceSupported(System.ComponentModel.ITypeDescriptorContext context) {
                return baseConverter.GetCreateInstanceSupported(context);
            }
            
            public override PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributeVar) {
                return baseConverter.GetProperties(context, value, attributeVar);
            }
            
            public override bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) {
                return baseConverter.GetPropertiesSupported(context);
            }
            
            public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) {
                return baseConverter.GetStandardValues(context);
            }
            
            public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) {
                return baseConverter.GetStandardValuesExclusive(context);
            }
            
            public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) {
                return baseConverter.GetStandardValuesSupported(context);
            }
            
            public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) {
                if ((baseType.BaseType == typeof(System.Enum))) {
                    if ((value.GetType() == destinationType)) {
                        return value;
                    }
                    if ((((value == null) 
                                && (context != null)) 
                                && (context.PropertyDescriptor.ShouldSerializeValue(context.Instance) == false))) {
                        return  "NULL_ENUM_VALUE" ;
                    }
                    return baseConverter.ConvertTo(context, culture, value, destinationType);
                }
                if (((baseType == typeof(bool)) 
                            && (baseType.BaseType == typeof(System.ValueType)))) {
                    if ((((value == null) 
                                && (context != null)) 
                                && (context.PropertyDescriptor.ShouldSerializeValue(context.Instance) == false))) {
                        return "";
                    }
                    return baseConverter.ConvertTo(context, culture, value, destinationType);
                }
                if (((context != null) 
                            && (context.PropertyDescriptor.ShouldSerializeValue(context.Instance) == false))) {
                    return "";
                }
                return baseConverter.ConvertTo(context, culture, value, destinationType);
            }
        }
        
        // Embedded class to represent WMI system Properties.
        [TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public class ManagementSystemProperties {
            
            private System.Management.ManagementBaseObject PrivateLateBoundObject;
            
            public ManagementSystemProperties(System.Management.ManagementBaseObject ManagedObject) {
                PrivateLateBoundObject = ManagedObject;
            }
            
            [Browsable(true)]
            public int GENUS {
                get {
                    return ((int)(PrivateLateBoundObject["__GENUS"]));
                }
            }
            
            [Browsable(true)]
            public string CLASS {
                get {
                    return ((string)(PrivateLateBoundObject["__CLASS"]));
                }
            }
            
            [Browsable(true)]
            public string SUPERCLASS {
                get {
                    return ((string)(PrivateLateBoundObject["__SUPERCLASS"]));
                }
            }
            
            [Browsable(true)]
            public string DYNASTY {
                get {
                    return ((string)(PrivateLateBoundObject["__DYNASTY"]));
                }
            }
            
            [Browsable(true)]
            public string RELPATH {
                get {
                    return ((string)(PrivateLateBoundObject["__RELPATH"]));
                }
            }
            
            [Browsable(true)]
            public int PROPERTY_COUNT {
                get {
                    return ((int)(PrivateLateBoundObject["__PROPERTY_COUNT"]));
                }
            }
            
            [Browsable(true)]
            public string[] DERIVATION {
                get {
                    return ((string[])(PrivateLateBoundObject["__DERIVATION"]));
                }
            }
            
            [Browsable(true)]
            public string SERVER {
                get {
                    return ((string)(PrivateLateBoundObject["__SERVER"]));
                }
            }
            
            [Browsable(true)]
            public string NAMESPACE {
                get {
                    return ((string)(PrivateLateBoundObject["__NAMESPACE"]));
                }
            }
            
            [Browsable(true)]
            public string PATH {
                get {
                    return ((string)(PrivateLateBoundObject["__PATH"]));
                }
            }
        }
    }
}
