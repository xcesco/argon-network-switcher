using System;
using System.ComponentModel;
using System.Management;
using System.Collections;
using System.Globalization;

namespace Argon.Hardware {    
    
    // Functions ShouldSerialize<PropertyName> are functions used by VS property browser to check if a particular property has to be serialized. These functions are added for all ValueType properties ( properties of type Int32, BOOL etc.. which cannot be set to null). These functions use Is<PropertyName>Null function. These functions are also used in the TypeConverter implementation for the properties to check for NULL value of property so that an empty value can be shown in Property browser in case of Drag and Drop in Visual studio.
    // Functions Is<PropertyName>Null() are used to check if a property is NULL.
    // Functions Reset<PropertyName> are added for Nullable Read/Write properties. These functions are used by VS designer in property browser to set a property to NULL.
    // Every property added to the class for WMI property has attributes set to define its behavior in Visual Studio designer and also to define a TypeConverter to be used.
    // Datetime conversion functions ToDateTime and ToDmtfDateTime are added to the class to convert DMTF datetime to System.DateTime and vice-versa.
    // An Early Bound class generated for the WMI class.Win32_NetworkAdapterConfiguration
    public class WmiNetworkAdapterConfiguration : System.ComponentModel.Component {
        
        // Private property to hold the WMI namespace in which the class resides.
        private static string CreatedWmiNamespace = "root\\CimV2";
        
        // Private property to hold the name of WMI class which created this class.
        private static string CreatedClassName = "Win32_NetworkAdapterConfiguration";
        
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
        public WmiNetworkAdapterConfiguration() {
            this.InitializeObject(null, null, null);
        }
        
        public WmiNetworkAdapterConfiguration(uint keyIndex) {
            this.InitializeObject(null, new System.Management.ManagementPath(WmiNetworkAdapterConfiguration.ConstructPath(keyIndex)), null);
        }
        
        public WmiNetworkAdapterConfiguration(System.Management.ManagementScope mgmtScope, uint keyIndex) {
            this.InitializeObject(((System.Management.ManagementScope)(mgmtScope)), new System.Management.ManagementPath(WmiNetworkAdapterConfiguration.ConstructPath(keyIndex)), null);
        }
        
        public WmiNetworkAdapterConfiguration(System.Management.ManagementPath path, System.Management.ObjectGetOptions getOptions) {
            this.InitializeObject(null, path, getOptions);
        }
        
        public WmiNetworkAdapterConfiguration(System.Management.ManagementScope mgmtScope, System.Management.ManagementPath path) {
            this.InitializeObject(mgmtScope, path, null);
        }
        
        public WmiNetworkAdapterConfiguration(System.Management.ManagementPath path) {
            this.InitializeObject(null, path, null);
        }
        
        public WmiNetworkAdapterConfiguration(System.Management.ManagementScope mgmtScope, System.Management.ManagementPath path, System.Management.ObjectGetOptions getOptions) {
            this.InitializeObject(mgmtScope, path, getOptions);
        }
        
        public WmiNetworkAdapterConfiguration(System.Management.ManagementObject theObject) {
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
        
        public WmiNetworkAdapterConfiguration(System.Management.ManagementBaseObject theObject) {
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
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsArpAlwaysSourceRouteNull {
            get {
                if ((curObj["ArpAlwaysSourceRoute"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"La proprietà ArpAlwaysSourceRoute indica se ARP (Address Resolution Protocol) deve sempre utilizzare l'origine di routing. Se questo parametro è impostato su TRUE, il protocollo TCP/IP trasmetterà query ARP con l'origine routing abilitata su reti Token Ring. In base all'impostazione predefinita, ARP trasmette per prime query senza origine di routing, quindi ripete l'operazione con l'origine routing abilitata in caso di mancata risposta. L'origine di routing consente il routing di pacchetti di rete su diversi tipi di rete. Valore predefinito: FALSE.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool ArpAlwaysSourceRoute {
            get {
                if ((curObj["ArpAlwaysSourceRoute"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["ArpAlwaysSourceRoute"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsArpUseEtherSNAPNull {
            get {
                if ((curObj["ArpUseEtherSNAP"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"La proprietà ArpUseEtherSNAP indica se per i pacchetti Ethernet verrà utilizzata la codifica SNAP IEEE 802.3. Se questo parametro viene impostato su 1, il protocollo TCP/IP trasmetterà i pacchetti Ethernet con la codifica SNAP 802.3. In base all'impostazione predefinita, lo stack trasmette i pacchetti in formato Ethernet DIX. Windows NT/2000 sono in grado di ricevere entrambi i formati. Valore predefinito: FALSE.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool ArpUseEtherSNAP {
            get {
                if ((curObj["ArpUseEtherSNAP"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["ArpUseEtherSNAP"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Breve descrizione (una stringa di una riga) dell\'oggetto CIM_Setting.")]
        public string Caption {
            get {
                return ((string)(curObj["Caption"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"La proprietà DatabasePath indica un percorso valido di un file Windows verso file di database Internet standard (HOSTS, LMHOSTS, NETWORKS, PROTOCOLS).  Il percorso del file viene utilizzato dall'interfaccia Windows Sockets. Questa proprietà è disponibile esclusivamente su sistema Windows NT/Windows 2000.")]
        public string DatabasePath {
            get {
                return ((string)(curObj["DatabasePath"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsDeadGWDetectEnabledNull {
            get {
                if ((curObj["DeadGWDetectEnabled"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"La proprietà DeadGWDetectEnabled indica se verrà effettuata la rilevazione di gateway inattivi. Se questo parametro viene impostato su TRUE, il protocollo TCP effettuerà la rilevazione dei gateway inattivi. Con questa funzione abilitata, il protocollo TCP richiederà all'indirizzo IP di utilizzare un gateway di backup se un segmento viene ritrasmesso più volte senza ricevere risposta. Valore predefinito: TRUE.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool DeadGWDetectEnabled {
            get {
                if ((curObj["DeadGWDetectEnabled"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["DeadGWDetectEnabled"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("La proprietà DefaultIPGateway contiene un elenco di indirizzi IP delle gateway pr" +
            "edefinite utilizzate dal computer.\nEsempio: 194.161.12.1 194.162.46.1")]
        public string[] DefaultIPGateway {
            get {
                return ((string[])(curObj["DefaultIPGateway"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsDefaultTOSNull {
            get {
                if ((curObj["DefaultTOS"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("La proprietà DefaultTOS indica il valore TOS (Type Of Service) predefinito nell\'i" +
            "ntestazione di pacchetti IP in uscita. Vedere la RFC 791 per una definizione dei" +
            " valori. Valore predefinito: 0. Intervallo valido: 0 - 255.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public byte DefaultTOS {
            get {
                if ((curObj["DefaultTOS"] == null)) {
                    return System.Convert.ToByte(0);
                }
                return ((byte)(curObj["DefaultTOS"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsDefaultTTLNull {
            get {
                if ((curObj["DefaultTTL"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"La proprietà DefaultTTL indica il valore TTL (Time to Live) predefinito nell'intestazione di pacchetti IP in uscita. Questo valore determina la durata massima dell'esistenza in rete di un pacchetto IP che non abbia raggiunto la destinazione. Durante il trasferimento, ogni router diminuisce il valore TTL di ogni pacchetto di una unità e scarta i pacchetti per i quali il valore TTL è 0. Valore predefinito: 32, Intervallo valido: 1 - 255.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public byte DefaultTTL {
            get {
                if ((curObj["DefaultTTL"] == null)) {
                    return System.Convert.ToByte(0);
                }
                return ((byte)(curObj["DefaultTTL"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Descrizione dell\'oggetto CIM_Setting.")]
        public string Description {
            get {
                return ((string)(curObj["Description"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsDHCPEnabledNull {
            get {
                if ((curObj["DHCPEnabled"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("La proprietà DHCPEnabled indica se il server DHCP (dynamic host configuration pro" +
            "tocol) assegna automaticamente un indirizzo IP al computer durante l\'inizializza" +
            "zione di una connessione di rete.\nValori: TRUE o FALSE. Se il valore è TRUE, DHC" +
            "P è attivato.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool DHCPEnabled {
            get {
                if ((curObj["DHCPEnabled"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["DHCPEnabled"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsDHCPLeaseExpiresNull {
            get {
                if ((curObj["DHCPLeaseExpires"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("La proprietà DHCPLeaseExpires indica la data e l\'ora di scadenza del lease di un " +
            "indirizzo IP assegnato al computer da un server DHCP (dynamic host configuration" +
            " protocol).\nEsempio: 20521201000230.000000000")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public System.DateTime DHCPLeaseExpires {
            get {
                if ((curObj["DHCPLeaseExpires"] != null)) {
                    return ToDateTime(((string)(curObj["DHCPLeaseExpires"])));
                }
                else {
                    return System.DateTime.MinValue;
                }
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsDHCPLeaseObtainedNull {
            get {
                if ((curObj["DHCPLeaseObtained"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("La proprietà DHCPLeaseObtained indica la data e l\'ora in cui è stato assegnato il" +
            " lease di un indirizzo IP al computer da un server DHCP (dynamic host configurat" +
            "ion protocol).\nEsempio: 19521201000230.000000000")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public System.DateTime DHCPLeaseObtained {
            get {
                if ((curObj["DHCPLeaseObtained"] != null)) {
                    return ToDateTime(((string)(curObj["DHCPLeaseObtained"])));
                }
                else {
                    return System.DateTime.MinValue;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("La proprietà DHCPServer indica l\'indirizzo IP del server DHCP (dynamic host confi" +
            "guration protocol).\nEsempio: 154.55.34")]
        public string DHCPServer {
            get {
                return ((string)(curObj["DHCPServer"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"La proprietà DNSDomain indica un nome di organizzazione seguito da un punto e da un'estensione che indica il tipo di organizzazione. ad esempio microsoft.com. Il nome può essere composto da una qualsiasi combinazione di lettere dalla A alla Z, numeri da 0 a 9 e dai separatori trattino (-) e punto (.).
Esempio: microsoft.com.")]
        public string DNSDomain {
            get {
                return ((string)(curObj["DNSDomain"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"La proprietà DNSDomainSuffixSearchOrder specifica i suffissi del dominio DNS da aggiungere ai nomi host durante la risoluzione dei nomi. Quando cerca di risolvere un nome di dominio completo solo da un nome host, il sistema aggiunge per primo il nome di dominio locale. Se la risoluzione del nome non viene effettuata, il sistema utilizza l'elenco dei suffissi di dominio per creare nomi completi di dominio nell'ordine elencato e interrogare i server DNS per ciascuno di essi.
Esempio: dev.microsoft.com test.microsoft.com.")]
        public string[] DNSDomainSuffixSearchOrder {
            get {
                return ((string[])(curObj["DNSDomainSuffixSearchOrder"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsDNSEnabledForWINSResolutionNull {
            get {
                if ((curObj["DNSEnabledForWINSResolution"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("La proprietà DNSEnabledForWINSResolution indica se il DNS (Domain Name System) è " +
            "attivato per la risoluzione dei nomi con la risoluzione WINS. Se non è possibile" +
            " risolvere il nome con il DNS, la richiesta di risoluzione viene inoltrata al WI" +
            "NS.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool DNSEnabledForWINSResolution {
            get {
                if ((curObj["DNSEnabledForWINSResolution"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["DNSEnabledForWINSResolution"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"La proprietà DNSHostName indica il nome host utilizzato per l'identificazione del computer locale in alcune utilità. In altre utilità basate su TCP/IP questo valore viene utilizzato per indicare il nome del computer locale. I nomi host sono memorizzati in una tabella del server DNS in cui i nomi sono associati a indirizzi host e che viene utilizzata da DNS. Il nome può essere composto da una qualsiasi combinazione di lettere dalla A alla Z, numeri da 0 a 9 e dai separatori trattino (-) e punto (.). In base all'impostazione predefinita, questo valore corrisponde al nome del computer di rete Microsoft, tuttavia l'amministratore della rete può assegnare un altro nome host senza modificare il nome del computer.
Esempio: dnssoc.")]
        public string DNSHostName {
            get {
                return ((string)(curObj["DNSHostName"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("La proprietà DNSServerSearchOrder indica un elenco ordinato di indirizzi IP del s" +
            "erver che potranno essere utilizzati per eseguire query relative a server DNS.")]
        public string[] DNSServerSearchOrder {
            get {
                return ((string[])(curObj["DNSServerSearchOrder"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsDomainDNSRegistrationEnabledNull {
            get {
                if ((curObj["DomainDNSRegistrationEnabled"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"La proprietà DomainDNSRegistrationEnabled specifica se gli indirizzi IP per la connessione sono registrati nel DNS con il nome di dominio della connessione, oltre al nome completo del computer. Il nome di dominio della connessione è impostato mediante il metodo SetDNSDomain() o assegnato da DHCP. Il nome registrato è il nome host del computer con il nome di dominio aggiunto. Solo Windows 2000.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool DomainDNSRegistrationEnabled {
            get {
                if ((curObj["DomainDNSRegistrationEnabled"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["DomainDNSRegistrationEnabled"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsForwardBufferMemoryNull {
            get {
                if ((curObj["ForwardBufferMemory"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"La proprietà ForwardBufferMemory indica la quantità di memoria allocata da IP per l'archiviazione dei dati del pacchetto nella coda dei pacchetti del router. Una volta esaurito lo spazio del buffer, il router inizierà a scartare pacchetti dalla coda in modo casuale. Ai buffer di dati della coda di pacchetti è assegnato uno spazio pari a 256 byte, pertanto il valore di questo parametro deve essere un multiplo di 256.  Per pacchetti di dimensioni maggiori vengono utilizzate concatenazioni di buffer. L'intestazione IP per un pacchetto viene memorizzato separatamente. Questo parametro viene ignorato e non vengono allocati buffer se il router IP non è attivato. La dimensione del buffer può essere compresa tra la MTU di rete e un valore minore di 0xFFFFFFFF. Valore predefinito: 74240 (cinquanta pacchetti da 1480 byte, arrotondato a un multiplo di 256).")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint ForwardBufferMemory {
            get {
                if ((curObj["ForwardBufferMemory"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["ForwardBufferMemory"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsFullDNSRegistrationEnabledNull {
            get {
                if ((curObj["FullDNSRegistrationEnabled"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"La proprietà FullDNSRegistrationEnabled specifica se gli indirizzi IP per la connessione sono registrati nel DNS con il nome completo del computer. Il nome DNS del computer viene mostrato sulla scheda Identificazione di rete nell'applet Sistema del Pannello di controllo. Solo Windows 2000.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool FullDNSRegistrationEnabled {
            get {
                if ((curObj["FullDNSRegistrationEnabled"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["FullDNSRegistrationEnabled"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"GatewayCostMetric seleziona un valore intero per la misurazione dei costi (intervallo compreso tra 1 e 9999) da utilizzare per calcolare le route più veloci, affidabili e/o meno costose. Questo argomento ha una corrispondenza uno a uno con DefaultIPGateway. Solo per Windows 2000.")]
        public ushort[] GatewayCostMetric {
            get {
                return ((ushort[])(curObj["GatewayCostMetric"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsIGMPLevelNull {
            get {
                if ((curObj["IGMPLevel"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"La proprietà IGMPLevel indica il livello di supporto offerto dal sistema per il multicast IP e partecipa al protocollo Internet Group Management Protocol. Al livello 0, il sistema non offre alcun supporto multicast. Al livello 1, il sistema è in grado di inviare soltanto pacchetti multicast IP. Al livello 2, Il sistema è in grado di inviare pacchetti multicast IP e di partecipare attivamente al protocollo IGMP per la ricezione di pacchetti multicast. Il valore predefinito è: 2")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public IGMPLevelValues IGMPLevel {
            get {
                if ((curObj["IGMPLevel"] == null)) {
                    return ((IGMPLevelValues)(System.Convert.ToInt32(3)));
                }
                return ((IGMPLevelValues)(System.Convert.ToInt32(curObj["IGMPLevel"])));
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
        [Description("La proprietà Index specifica il numero di indice della configurazione della sched" +
            "a di rete Win32. Il numero di indice viene utilizzato quando è disponibile più d" +
            "i una configurazione.")]
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
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("La proprietà IPAddress contiene un elenco di tutti gli indirizzi IP associati all" +
            "a scheda di rete corrente.\nEsempio: 155.34.22.0")]
        public string[] IPAddress {
            get {
                return ((string[])(curObj["IPAddress"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsIPConnectionMetricNull {
            get {
                if ((curObj["IPConnectionMetric"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"IPConnectionMetric indica il costo implicito nell'utilizzo di route configurate per la scheda con binding IP e rappresenta il valore misurato per quelle route nella tabella di routing IP. Se nella tabella sono indicate route multiple verso una destinazione, viene utilizzata la route con metrica minore. Il valore predefinito è 1. Solo Windows 2000.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint IPConnectionMetric {
            get {
                if ((curObj["IPConnectionMetric"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["IPConnectionMetric"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsIPEnabledNull {
            get {
                if ((curObj["IPEnabled"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("La proprietà IPEnabled indica se TCP/IP è in binding o abilitato sulla scheda di " +
            "rete.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool IPEnabled {
            get {
                if ((curObj["IPEnabled"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["IPEnabled"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsIPFilterSecurityEnabledNull {
            get {
                if ((curObj["IPFilterSecurityEnabled"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"La proprietà IPFilterSecurityEnabled indica se la sicurezza delle porte IP è attivata su tutte le schede di rete collegate a IP. Questa proprietà viene utilizzata unitamente a IPSecPermitTCPPorts, IPSecPermitUDPPorts e IPSecPermitIPProtocols. Il valore TRUE indica che la sicurezza delle porte IP è attivata e che i valori relativi alla sicurezza associati alle singole schede di rete sono in uso. Il valore FALSE indica che la sicurezza dei filtri IP è disattivata su tutte le schede di rete e che il traffico del protocollo e della porta non è regolato da alcun filtro.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool IPFilterSecurityEnabled {
            get {
                if ((curObj["IPFilterSecurityEnabled"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["IPFilterSecurityEnabled"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsIPPortSecurityEnabledNull {
            get {
                if ((curObj["IPPortSecurityEnabled"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("La proprietà IPPortSecurityEnabled indica se la sicurezza delle porte IP è attiva" +
            "ta su tutte le schede di rete collegate a IP. Questa proprietà è stata dichiarat" +
            "a obsoleta ed è stata sostituita dalla proprietà IPFilterSecurityEnabled.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool IPPortSecurityEnabled {
            get {
                if ((curObj["IPPortSecurityEnabled"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["IPPortSecurityEnabled"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"La proprietà IPSecPermitIPProtocols elenca i protocolli ai quali è consentita l'esecuzione nell'IP. L'elenco di protocolli è definito mediante il metodo EnableIPSec. L'elenco sarà vuoto o conterrà solo valori numerici. Il valore 0 (zero) indica che è consentita l'esecuzione di tutti i protocolli. Una stringa vuota indica che non è consentita l'esecuzione di nessun protocollo quando il valore di IPFilterSecurityEnabled è TRUE.")]
        public string[] IPSecPermitIPProtocols {
            get {
                return ((string[])(curObj["IPSecPermitIPProtocols"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"La proprietà IPSecPermitTCPPorts elenca le porte alle quali verrà consentito l'accesso per TCP. L'elenco di protocolli è definito mediante il metodo EnableIPSec. L'elenco sarà vuoto o conterrà solo valori numerici. Il valore 0 (zero) indica che è consentito l'accesso a tutte le porte. Una stringa vuota indica che non è consentito l'accesso a nessuna porta quando il valore di IPFilterSecurityEnabled è TRUE.")]
        public string[] IPSecPermitTCPPorts {
            get {
                return ((string[])(curObj["IPSecPermitTCPPorts"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"La proprietà IPSecPermitUDPPorts elenca le porte alle quali verrà consentito l'accesso UDP. L'elenco di protocolli è definito mediante il metodo EnableIPSec. L'elenco sarà vuoto o conterrà solo valori numerici. Il valore 0 (zero) indica che è consentito l'accesso a tutte le porte. Una stringa vuota indica che non è consentito l'accesso a nessuna porta quando il valore di IPFilterSecurityEnabled è TRUE.")]
        public string[] IPSecPermitUDPPorts {
            get {
                return ((string[])(curObj["IPSecPermitUDPPorts"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("La proprietà IPSubnet contiene un elenco di tutte le subnet mask associate alla s" +
            "cheda di rete corrente.\nEsempio: 255.255.0")]
        public string[] IPSubnet {
            get {
                return ((string[])(curObj["IPSubnet"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsIPUseZeroBroadcastNull {
            get {
                if ((curObj["IPUseZeroBroadcast"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"La proprietà IPUseZeroBroadcast indica se verranno utilizzate trasmissioni con indirizzo IP pari a 0. Se questo parametro è impostato su TRUE, l'indirizzo IP utilizzerà trasmissioni di tipo zero (0.0.0.0) e il sistema trasmissioni di tipo uno (255.255.255.255). Nella maggior parte dei sistemi vengono utilizzati trasmissioni di tipo uno, tuttavia alcuni sistemi derivati da implementazioni BSD utilizzando trasmissioni di tipo zero. I sistemi che utilizzano trasmissioni diverse potrebbero non interagire correttamente nell'ambito della stessa rete. Valore predefinito: FALSE.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool IPUseZeroBroadcast {
            get {
                if ((curObj["IPUseZeroBroadcast"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["IPUseZeroBroadcast"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("La proprietà IPXAddress indica l\'indirizzo IPX (Internetworking Packet Exchange) " +
            "della scheda di rete. L\'indirizzo IPX identifica un computer su una rete che uti" +
            "lizza il protocollo IPX.")]
        public string IPXAddress {
            get {
                return ((string)(curObj["IPXAddress"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsIPXEnabledNull {
            get {
                if ((curObj["IPXEnabled"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("La proprietà IPXEnabled indica se IPX (Internetwork Packet Exchange) è in binding" +
            " o abilitato sulla scheda di rete.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool IPXEnabled {
            get {
                if ((curObj["IPXEnabled"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["IPXEnabled"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("La proprietà IPXFrameType rappresenta un array intero di identificativi del tipo " +
            "di frame. I valori in questo array corrispondono agli elementi indicati in IPXNe" +
            "tworkNumber.")]
        public IPXFrameTypeValues[] IPXFrameType {
            get {
                System.Array arrEnumVals = ((System.Array)(curObj["IPXFrameType"]));
                IPXFrameTypeValues[] enumToRet = new IPXFrameTypeValues[arrEnumVals.Length];
                int counter = 0;
                for (counter = 0; (counter < arrEnumVals.Length); counter = (counter + 1)) {
                    enumToRet[counter] = ((IPXFrameTypeValues)(System.Convert.ToInt32(arrEnumVals.GetValue(counter))));
                }
                return enumToRet;
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsIPXMediaTypeNull {
            get {
                if ((curObj["IPXMediaType"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("La proprietà IPXMediaType rappresenta un identificativo di un tipo di supporto IP" +
            "X (Internetworking Packet Exchange).")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public IPXMediaTypeValues IPXMediaType {
            get {
                if ((curObj["IPXMediaType"] == null)) {
                    return ((IPXMediaTypeValues)(System.Convert.ToInt32(0)));
                }
                return ((IPXMediaTypeValues)(System.Convert.ToInt32(curObj["IPXMediaType"])));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"La proprietà IPXNetworkNumber rappresenta una array di caratteri che identifica in modo univoco la combinazione scheda di rete e frame sul sistema. In Windows 2000, Windows NT 4.0 e versioni successive, il trasporto NetWare Link (NWLink) IPX/SPX compatibile utilizza due tipi distinti di numeri di rete. Questo numero è anche noto come numero di rete esterno e deve essere univoco per ogni segmento di rete. L'ordine degli elementi in questo elenco di stringhe corrisponderà a quello degli elementi indicati nella proprietà IPXFrameType.")]
        public string[] IPXNetworkNumber {
            get {
                return ((string[])(curObj["IPXNetworkNumber"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"La proprietà IPXVirtualNetNumber identifica in modo univoco il sistema sulla rete. Questa proprietà è rappresentata da una cifra digitale esadecimale di otto caratteri. In Windows NT/2000 il numero di rete virtuale (anche noto come numero di rete interno) viene utilizzato per il routing interno.")]
        public string IPXVirtualNetNumber {
            get {
                return ((string)(curObj["IPXVirtualNetNumber"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsKeepAliveIntervalNull {
            get {
                if ((curObj["KeepAliveInterval"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"La proprietà KeepAliveInterval determina l'intervallo tra ritrasmissioni Keep Alive fino a quando non viene ricevuta una risposta. Una volta ricevuta una risposta, l'intervallo con la successiva trasmissione Keep Alive viene gestito da KeepAliveTime. La connessione verrà annullata una volta superato il numero di ritrasmissioni specificato in TcpMaxDataRetransmissions senza ricevere risposta. Valore predefinito: 1000, Intervallo valido: 1 - 0xFFFFFFFF.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint KeepAliveInterval {
            get {
                if ((curObj["KeepAliveInterval"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["KeepAliveInterval"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsKeepAliveTimeNull {
            get {
                if ((curObj["KeepAliveTime"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"La proprietà KeepAliveTime determina il numero di tentativi effettuati da TCP per verificare l'integrità di una connessione inattiva mediante l'invio di un pacchetto Keep Alive. Se il sistema remoto è ancora raggiungibile e attivo, segnala l'avvenuta trasmissione del pacchetto Keep Alive. In base all'impostazione predefinita, i pacchetti Keep Alive non vengono inviati. Questa funzione può essere attivata da un'applicazione durante una connessione. Valore predefinito: 7,200,000 (due ore)")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint KeepAliveTime {
            get {
                if ((curObj["KeepAliveTime"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["KeepAliveTime"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("La proprietà MACAddress indica l\'indirizzo MAC (Media Access Control) della sched" +
            "a di rete. Un indirizzo MAC viene assegnato dal produttore per identificare univ" +
            "ocamente la scheda di rete.\nEsempio: 00:80:C7:8F:6C:96")]
        public string MACAddress {
            get {
                return ((string)(curObj["MACAddress"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsMTUNull {
            get {
                if ((curObj["MTU"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"La proprietà MTU sostituisce il valore predefinito MTU (Maximum Transmission Unit) per un'interfaccia di rete. Il valore MTU corrisponde alla dimensione massima del pacchetto. (inclusa l'intestazione del trasporto) che il trasporto trasmetterà nell'ambito della rete sottostante. Il datagramma IP può occupare più pacchetti. L'intervallo di questo valore estende la dimensione minima del pacchetto (68) alla MTU supportata dalla rete sottostante.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint MTU {
            get {
                if ((curObj["MTU"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["MTU"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsNumForwardPacketsNull {
            get {
                if ((curObj["NumForwardPackets"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"La proprietà NumForwardPackets determina il numero di intestazioni di pacchetti IP allocate per la coda di pacchetti del router. Quando vengono utilizzate tutte le intestazioni, il router inizierà a scartare pacchetti dalla coda in modo casuale. Questo valore deve essere almeno uguale al valore di ForwardBufferMemory diviso per la dimensione massima dei dati IP delle reti collegate al router. Non deve essere maggiore del valore di ForwardBufferMemory diviso per 256, poiché per ciascun pacchetto vengono utilizzati almeno 256 byte di memoria buffer di inoltro. Il numero ottimale di pacchetti di inoltro per una dimensione specifica di ForwardBufferMemory dipende dal tipo di traffico di rete e sarà comunque compreso tra questi due valori. Questo parametro viene ignorato e non vengono allocate intestazioni se il router non è attivato. Valore predefinito: 50, Intervallo valido: 1 - 0xFFFFFFFE.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint NumForwardPackets {
            get {
                if ((curObj["NumForwardPackets"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["NumForwardPackets"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsPMTUBHDetectEnabledNull {
            get {
                if ((curObj["PMTUBHDetectEnabled"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"La proprietà PMTUBHDetectEnabled indica se verrà effettuato il rilevamento di router black hole. Se questo parametro viene impostato su TRUE, il protocollo TCP proverà a rilevare i router black hole durante l'individuazione del percorso dell'Unità massima di trasmissione (MTU, Maximum Transmission Unit). Un router black hole non restituisce messaggi relativi all'impossibilità di raggiungere la destinazione ICMP quando richiede la frammentazione di un datagramma IP per il quale è impostato il bit per la disattivazione della frammentazione. Il TCP si basa su questi messaggi per eseguire l'individuazione del percorso MTU. Con questa funzione attivata, il TCP proverà a inviare segmenti per i quali non è impostato il bit di disattivazione della frammentazione in caso di mancata risposta a più ritrasmissioni di un segmento. Se il segmento viene riconosciuto, il valore di MSS verrà diminuito e il bit di disattivazione della frammentazione verrà nuovamente impostato per i pacchetti successivi inviati durante la connessione. L'attivazione della funzionalità di rilevamento di black hole aumenta il numero massimo di ritrasmissioni effettuate per un dato segmento. Il valore predefinito di questa proprietà è FALSE.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool PMTUBHDetectEnabled {
            get {
                if ((curObj["PMTUBHDetectEnabled"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["PMTUBHDetectEnabled"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsPMTUDiscoveryEnabledNull {
            get {
                if ((curObj["PMTUDiscoveryEnabled"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"La proprietà PMTUDiscoveryEnabled indica se il percorso Unità massima di trasmissione (MTU, Maximum Transmission Unit) viene rilevato. Se si imposta questo parametro su TRUE, il protocollo TCP tenterà di individuare il valore di MTU (la dimensione del pacchetto più grande) sul percorso di un host remoto. Rilevando il valore MTU del percorso e limitando i segmenti TCP a questa dimensione, TCP è in grado di eliminare la frammentazione sui router lungo il percorso che connette le reti alle diverse MTU. La frammentazione influisce negativamente sulla velocità effettiva del protocollo TCP e sulla congestione di rete. Se si imposta questo parametro su FALSE, una MTU di 576 byte verrà utilizzata per tutte le connessioni che non siano su computer della subnet locale. Valore predefinito: TRUE.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool PMTUDiscoveryEnabled {
            get {
                if ((curObj["PMTUDiscoveryEnabled"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["PMTUDiscoveryEnabled"]));
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
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Identificatore dell\'oggetto CIM_Setting.")]
        public string SettingID {
            get {
                return ((string)(curObj["SettingID"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsTcpipNetbiosOptionsNull {
            get {
                if ((curObj["TcpipNetbiosOptions"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("La proprietà TcpipNetbiosOptions specifica una bitmap delle possibili impostazion" +
            "i relative al NetBIOS su TCP/IP. Solo Windows 2000.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public TcpipNetbiosOptionsValues TcpipNetbiosOptions {
            get {
                if ((curObj["TcpipNetbiosOptions"] == null)) {
                    return ((TcpipNetbiosOptionsValues)(System.Convert.ToInt32(3)));
                }
                return ((TcpipNetbiosOptionsValues)(System.Convert.ToInt32(curObj["TcpipNetbiosOptions"])));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsTcpMaxConnectRetransmissionsNull {
            get {
                if ((curObj["TcpMaxConnectRetransmissions"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"La proprietà TcpMaxConnectRetransmissions determina il numero dei tentativi effettuati da TCP di ritrasmettere una richiesta di connessione prima di terminare la connessione. Il timeout di ritrasmissione iniziale è di 3 secondi. Il timeout di ritrasmissione viene raddoppiato ad ogni tentativo. Valore predefinito: 3, Intervallo valido: 0 - 0xFFFFFFFF.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint TcpMaxConnectRetransmissions {
            get {
                if ((curObj["TcpMaxConnectRetransmissions"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["TcpMaxConnectRetransmissions"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsTcpMaxDataRetransmissionsNull {
            get {
                if ((curObj["TcpMaxDataRetransmissions"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"La proprietà TcpMaxDataRetransmissions determina il numero di volte in cui TCP ritrasmetterà un singolo segmento di dati (non di connessione) prima di annullare la connessione. Il timeout di ritrasmissione viene raddoppiato a ogni ritrasmissione successiva in una determinata connessione. Valore predefinito: 5, Intervallo valido: 0 - 0xFFFFFFFF.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint TcpMaxDataRetransmissions {
            get {
                if ((curObj["TcpMaxDataRetransmissions"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["TcpMaxDataRetransmissions"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsTcpNumConnectionsNull {
            get {
                if ((curObj["TcpNumConnections"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("La proprietà TcpNumConnections indica il numero massimo di connessioni aperte dis" +
            "ponibili per TCP contemporaneamente. Il valore di timeout iniziale è pari a tre " +
            "secondi. Valore predefinito: 0xFFFFFE, Intervallo valido: 0 - 0xFFFFFE.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint TcpNumConnections {
            get {
                if ((curObj["TcpNumConnections"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["TcpNumConnections"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsTcpUseRFC1122UrgentPointerNull {
            get {
                if ((curObj["TcpUseRFC1122UrgentPointer"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"La proprietà TcpUseRFC1122UrgentPointer determina se TCP utilizzerà la specifica RFC 1122 per i dati urgenti oppure la modalità impiegata da sistemi derivati da BSD. I due meccanismi interpretano in modo diverso il puntatore di urgenza e non sono interscambiabili. L'impostazione predefinita di Windows 2000 e Windows NT versione 3.51 e successive è la modalità BSD. Se è impostata su TRUE, i dati urgenti vengono inviati in modalità RFC 1122. Valore predefinito: FALSE.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool TcpUseRFC1122UrgentPointer {
            get {
                if ((curObj["TcpUseRFC1122UrgentPointer"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["TcpUseRFC1122UrgentPointer"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsTcpWindowSizeNull {
            get {
                if ((curObj["TcpWindowSize"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"La proprietà TcpWindowSize determina la dimensione massima della finestra di ricezione TCP offerta dal sistema. La finestra di ricezione consente di specificare il numero di byte che una periferica di invio può trasmettere senza ricevere un riconoscimento. In generale finestre di ricezione maggiori consentono di migliorare le prestazioni in reti ad alta velocità e ad ampia larghezza di banda. Per la massima efficienza la finestra di ricezione dovrebbe essere un multiplo pari del valore MSS (Maximum Segment Size) TCP. Valore predefinito: quattro volte la dimensione massima dei dati TCP o un multiplo pari della dimensione massima dei dati TCP arrotondato al multiplo più vicino a 8192. Il valore predefinito per le reti Ethernet è 8760. Intervallo valido: 0 - 65535.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public ushort TcpWindowSize {
            get {
                if ((curObj["TcpWindowSize"] == null)) {
                    return System.Convert.ToUInt16(0);
                }
                return ((ushort)(curObj["TcpWindowSize"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsWINSEnableLMHostsLookupNull {
            get {
                if ((curObj["WINSEnableLMHostsLookup"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("La proprietà WINSEnableLMHostsLookup indica se verranno utilizzati i file di rice" +
            "rca locali. I file di ricerca conterranno le associazioni tra indirizzi IP e nom" +
            "i host. Se esistenti, tali nomi sono reperibili in %SystemRoot%\\system32\\drivers" +
            "\\etc.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool WINSEnableLMHostsLookup {
            get {
                if ((curObj["WINSEnableLMHostsLookup"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["WINSEnableLMHostsLookup"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"La proprietà WINSHostLookupFile contiene un percorso per il file di ricerca WINS nel sistema locale. Tale file conterrà le associazioni tra indirizzi IP e nomi host. Se il file specificato in questa proprietà viene rilevato, verrà copiato nella cartella %SystemRoot%\system32\drivers\etc del sistema locale. Valido solo se la proprietà WINSEnableLMHostsLookup è impostata su TRUE.")]
        public string WINSHostLookupFile {
            get {
                return ((string)(curObj["WINSHostLookupFile"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("La proprietà WINSPrimaryServer indica l\'indirizzo IP per il server WINS primario." +
            " ")]
        public string WINSPrimaryServer {
            get {
                return ((string)(curObj["WINSPrimaryServer"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"La proprietà WINSScopeID consente di isolare un gruppo di computer che comunicano solo tra loro. L'ID Ambito è una stringa di caratteri aggiunta al nome NetBIOS che viene utilizzata per tutte le comunicazioni NetBIOS su TCP/IP da tale computer. I computer configurati con lo stesso ID Ambito saranno in grado di comunicare con questo computer, mentre i client TCP/IP con un ID Ambito diverso ignoreranno i pacchetti provenienti dai computer con questo ID Ambito. Valido solo quando il metodo EnableWINS viene eseguito correttamente.")]
        public string WINSScopeID {
            get {
                return ((string)(curObj["WINSScopeID"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("La proprietà WINSSecondaryServer indica l\'indirizzo IP per il server WINS seconda" +
            "rio. ")]
        public string WINSSecondaryServer {
            get {
                return ((string)(curObj["WINSSecondaryServer"]));
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
        
        private bool ShouldSerializeArpAlwaysSourceRoute() {
            if ((this.IsArpAlwaysSourceRouteNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeArpUseEtherSNAP() {
            if ((this.IsArpUseEtherSNAPNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeDeadGWDetectEnabled() {
            if ((this.IsDeadGWDetectEnabledNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeDefaultTOS() {
            if ((this.IsDefaultTOSNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeDefaultTTL() {
            if ((this.IsDefaultTTLNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeDHCPEnabled() {
            if ((this.IsDHCPEnabledNull == false)) {
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
        
        private bool ShouldSerializeDHCPLeaseExpires() {
            if ((this.IsDHCPLeaseExpiresNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeDHCPLeaseObtained() {
            if ((this.IsDHCPLeaseObtainedNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeDNSEnabledForWINSResolution() {
            if ((this.IsDNSEnabledForWINSResolutionNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeDomainDNSRegistrationEnabled() {
            if ((this.IsDomainDNSRegistrationEnabledNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeForwardBufferMemory() {
            if ((this.IsForwardBufferMemoryNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeFullDNSRegistrationEnabled() {
            if ((this.IsFullDNSRegistrationEnabledNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeIGMPLevel() {
            if ((this.IsIGMPLevelNull == false)) {
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
        
        private bool ShouldSerializeInterfaceIndex() {
            if ((this.IsInterfaceIndexNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeIPConnectionMetric() {
            if ((this.IsIPConnectionMetricNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeIPEnabled() {
            if ((this.IsIPEnabledNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeIPFilterSecurityEnabled() {
            if ((this.IsIPFilterSecurityEnabledNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeIPPortSecurityEnabled() {
            if ((this.IsIPPortSecurityEnabledNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeIPUseZeroBroadcast() {
            if ((this.IsIPUseZeroBroadcastNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeIPXEnabled() {
            if ((this.IsIPXEnabledNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeIPXMediaType() {
            if ((this.IsIPXMediaTypeNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeKeepAliveInterval() {
            if ((this.IsKeepAliveIntervalNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeKeepAliveTime() {
            if ((this.IsKeepAliveTimeNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeMTU() {
            if ((this.IsMTUNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeNumForwardPackets() {
            if ((this.IsNumForwardPacketsNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializePMTUBHDetectEnabled() {
            if ((this.IsPMTUBHDetectEnabledNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializePMTUDiscoveryEnabled() {
            if ((this.IsPMTUDiscoveryEnabledNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeTcpipNetbiosOptions() {
            if ((this.IsTcpipNetbiosOptionsNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeTcpMaxConnectRetransmissions() {
            if ((this.IsTcpMaxConnectRetransmissionsNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeTcpMaxDataRetransmissions() {
            if ((this.IsTcpMaxDataRetransmissionsNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeTcpNumConnections() {
            if ((this.IsTcpNumConnectionsNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeTcpUseRFC1122UrgentPointer() {
            if ((this.IsTcpUseRFC1122UrgentPointerNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeTcpWindowSize() {
            if ((this.IsTcpWindowSizeNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeWINSEnableLMHostsLookup() {
            if ((this.IsWINSEnableLMHostsLookupNull == false)) {
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
        
        private static string ConstructPath(uint keyIndex) {
            string strPath = "root\\CimV2:Win32_NetworkAdapterConfiguration";
            strPath = string.Concat(strPath, string.Concat(".Index=", ((System.UInt32 )(keyIndex)).ToString()));
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
        public static NetworkAdapterConfigurationCollection GetInstances() {
            return GetInstances(null, null, null);
        }
        
        public static NetworkAdapterConfigurationCollection GetInstances(string condition) {
            return GetInstances(null, condition, null);
        }
        
        public static NetworkAdapterConfigurationCollection GetInstances(System.String [] selectedProperties) {
            return GetInstances(null, null, selectedProperties);
        }
        
        public static NetworkAdapterConfigurationCollection GetInstances(string condition, System.String [] selectedProperties) {
            return GetInstances(null, condition, selectedProperties);
        }
        
        public static NetworkAdapterConfigurationCollection GetInstances(System.Management.ManagementScope mgmtScope, System.Management.EnumerationOptions enumOptions) {
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
            pathObj.ClassName = "Win32_NetworkAdapterConfiguration";
            pathObj.NamespacePath = "root\\CimV2";
            System.Management.ManagementClass clsObject = new System.Management.ManagementClass(mgmtScope, pathObj, null);
            if ((enumOptions == null)) {
                enumOptions = new System.Management.EnumerationOptions();
                enumOptions.EnsureLocatable = true;
            }
            return new NetworkAdapterConfigurationCollection(clsObject.GetInstances(enumOptions));
        }
        
        public static NetworkAdapterConfigurationCollection GetInstances(System.Management.ManagementScope mgmtScope, string condition) {
            return GetInstances(mgmtScope, condition, null);
        }
        
        public static NetworkAdapterConfigurationCollection GetInstances(System.Management.ManagementScope mgmtScope, System.String [] selectedProperties) {
            return GetInstances(mgmtScope, null, selectedProperties);
        }
        
        public static NetworkAdapterConfigurationCollection GetInstances(System.Management.ManagementScope mgmtScope, string condition, System.String [] selectedProperties) {
            if ((mgmtScope == null)) {
                if ((statMgmtScope == null)) {
                    mgmtScope = new System.Management.ManagementScope();
                    mgmtScope.Path.NamespacePath = "root\\CimV2";
                }
                else {
                    mgmtScope = statMgmtScope;
                }
            }
            System.Management.ManagementObjectSearcher ObjectSearcher = new System.Management.ManagementObjectSearcher(mgmtScope, new SelectQuery("Win32_NetworkAdapterConfiguration", condition, selectedProperties));
            System.Management.EnumerationOptions enumOptions = new System.Management.EnumerationOptions();
            enumOptions.EnsureLocatable = true;
            ObjectSearcher.Options = enumOptions;
            return new NetworkAdapterConfigurationCollection(ObjectSearcher.Get());
        }
        
        [Browsable(true)]
        public static WmiNetworkAdapterConfiguration CreateInstance() {
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
            return new WmiNetworkAdapterConfiguration(tmpMgmtClass.CreateInstance());
        }
        
        [Browsable(true)]
        public void Delete() {
            PrivateLateBoundObject.Delete();
        }
        
        public uint DisableIPSec() {
            if ((isEmbedded == false)) {
                System.Management.ManagementBaseObject inParams = null;
                System.Management.ManagementBaseObject outParams = PrivateLateBoundObject.InvokeMethod("DisableIPSec", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public uint EnableDHCP() {
            if ((isEmbedded == false)) {
                System.Management.ManagementBaseObject inParams = null;
                System.Management.ManagementBaseObject outParams = PrivateLateBoundObject.InvokeMethod("EnableDHCP", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public static uint EnableDNS(string DNSDomain, string[] DNSDomainSuffixSearchOrder, string DNSHostName, string[] DNSServerSearchOrder) {
            bool IsMethodStatic = true;
            if ((IsMethodStatic == true)) {
                System.Management.ManagementBaseObject inParams = null;
                System.Management.ManagementPath mgmtPath = new System.Management.ManagementPath(CreatedClassName);
                System.Management.ManagementClass classObj = new System.Management.ManagementClass(statMgmtScope, mgmtPath, null);
                inParams = classObj.GetMethodParameters("EnableDNS");
                inParams["DNSDomain"] = ((System.String )(DNSDomain));
                inParams["DNSDomainSuffixSearchOrder"] = ((string[])(DNSDomainSuffixSearchOrder));
                inParams["DNSHostName"] = ((System.String )(DNSHostName));
                inParams["DNSServerSearchOrder"] = ((string[])(DNSServerSearchOrder));
                System.Management.ManagementBaseObject outParams = classObj.InvokeMethod("EnableDNS", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public static uint EnableIPFilterSec(bool IPFilterSecurityEnabled) {
            bool IsMethodStatic = true;
            if ((IsMethodStatic == true)) {
                System.Management.ManagementBaseObject inParams = null;
                System.Management.ManagementPath mgmtPath = new System.Management.ManagementPath(CreatedClassName);
                System.Management.ManagementClass classObj = new System.Management.ManagementClass(statMgmtScope, mgmtPath, null);
                inParams = classObj.GetMethodParameters("EnableIPFilterSec");
                inParams["IPFilterSecurityEnabled"] = ((System.Boolean )(IPFilterSecurityEnabled));
                System.Management.ManagementBaseObject outParams = classObj.InvokeMethod("EnableIPFilterSec", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public uint EnableIPSec(string[] IPSecPermitIPProtocols, string[] IPSecPermitTCPPorts, string[] IPSecPermitUDPPorts) {
            if ((isEmbedded == false)) {
                System.Management.ManagementBaseObject inParams = null;
                inParams = PrivateLateBoundObject.GetMethodParameters("EnableIPSec");
                inParams["IPSecPermitIPProtocols"] = ((string[])(IPSecPermitIPProtocols));
                inParams["IPSecPermitTCPPorts"] = ((string[])(IPSecPermitTCPPorts));
                inParams["IPSecPermitUDPPorts"] = ((string[])(IPSecPermitUDPPorts));
                System.Management.ManagementBaseObject outParams = PrivateLateBoundObject.InvokeMethod("EnableIPSec", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public uint EnableStatic(string[] IPAddress, string[] SubnetMask) {
            if ((isEmbedded == false)) {
                System.Management.ManagementBaseObject inParams = null;
                inParams = PrivateLateBoundObject.GetMethodParameters("EnableStatic");
                inParams["IPAddress"] = ((string[])(IPAddress));
                inParams["SubnetMask"] = ((string[])(SubnetMask));
                System.Management.ManagementBaseObject outParams = PrivateLateBoundObject.InvokeMethod("EnableStatic", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public static uint EnableWINS(bool DNSEnabledForWINSResolution, bool WINSEnableLMHostsLookup, string WINSHostLookupFile, string WINSScopeID) {
            bool IsMethodStatic = true;
            if ((IsMethodStatic == true)) {
                System.Management.ManagementBaseObject inParams = null;
                System.Management.ManagementPath mgmtPath = new System.Management.ManagementPath(CreatedClassName);
                System.Management.ManagementClass classObj = new System.Management.ManagementClass(statMgmtScope, mgmtPath, null);
                inParams = classObj.GetMethodParameters("EnableWINS");
                inParams["DNSEnabledForWINSResolution"] = ((System.Boolean )(DNSEnabledForWINSResolution));
                inParams["WINSEnableLMHostsLookup"] = ((System.Boolean )(WINSEnableLMHostsLookup));
                inParams["WINSHostLookupFile"] = ((System.String )(WINSHostLookupFile));
                inParams["WINSScopeID"] = ((System.String )(WINSScopeID));
                System.Management.ManagementBaseObject outParams = classObj.InvokeMethod("EnableWINS", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public uint ReleaseDHCPLease() {
            if ((isEmbedded == false)) {
                System.Management.ManagementBaseObject inParams = null;
                System.Management.ManagementBaseObject outParams = PrivateLateBoundObject.InvokeMethod("ReleaseDHCPLease", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public static uint ReleaseDHCPLeaseAll() {
            bool IsMethodStatic = true;
            if ((IsMethodStatic == true)) {
                System.Management.ManagementBaseObject inParams = null;
                System.Management.ManagementPath mgmtPath = new System.Management.ManagementPath(CreatedClassName);
                System.Management.ManagementClass classObj = new System.Management.ManagementClass(statMgmtScope, mgmtPath, null);
                System.Management.ManagementBaseObject outParams = classObj.InvokeMethod("ReleaseDHCPLeaseAll", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public uint RenewDHCPLease() {
            if ((isEmbedded == false)) {
                System.Management.ManagementBaseObject inParams = null;
                System.Management.ManagementBaseObject outParams = PrivateLateBoundObject.InvokeMethod("RenewDHCPLease", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public static uint RenewDHCPLeaseAll() {
            bool IsMethodStatic = true;
            if ((IsMethodStatic == true)) {
                System.Management.ManagementBaseObject inParams = null;
                System.Management.ManagementPath mgmtPath = new System.Management.ManagementPath(CreatedClassName);
                System.Management.ManagementClass classObj = new System.Management.ManagementClass(statMgmtScope, mgmtPath, null);
                System.Management.ManagementBaseObject outParams = classObj.InvokeMethod("RenewDHCPLeaseAll", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public static uint SetArpAlwaysSourceRoute(bool ArpAlwaysSourceRoute) {
            bool IsMethodStatic = true;
            if ((IsMethodStatic == true)) {
                System.Management.ManagementBaseObject inParams = null;
                System.Management.ManagementPath mgmtPath = new System.Management.ManagementPath(CreatedClassName);
                System.Management.ManagementClass classObj = new System.Management.ManagementClass(statMgmtScope, mgmtPath, null);
                inParams = classObj.GetMethodParameters("SetArpAlwaysSourceRoute");
                inParams["ArpAlwaysSourceRoute"] = ((System.Boolean )(ArpAlwaysSourceRoute));
                System.Management.ManagementBaseObject outParams = classObj.InvokeMethod("SetArpAlwaysSourceRoute", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public static uint SetArpUseEtherSNAP(bool ArpUseEtherSNAP) {
            bool IsMethodStatic = true;
            if ((IsMethodStatic == true)) {
                System.Management.ManagementBaseObject inParams = null;
                System.Management.ManagementPath mgmtPath = new System.Management.ManagementPath(CreatedClassName);
                System.Management.ManagementClass classObj = new System.Management.ManagementClass(statMgmtScope, mgmtPath, null);
                inParams = classObj.GetMethodParameters("SetArpUseEtherSNAP");
                inParams["ArpUseEtherSNAP"] = ((System.Boolean )(ArpUseEtherSNAP));
                System.Management.ManagementBaseObject outParams = classObj.InvokeMethod("SetArpUseEtherSNAP", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public static uint SetDatabasePath(string DatabasePath) {
            bool IsMethodStatic = true;
            if ((IsMethodStatic == true)) {
                System.Management.ManagementBaseObject inParams = null;
                System.Management.ManagementPath mgmtPath = new System.Management.ManagementPath(CreatedClassName);
                System.Management.ManagementClass classObj = new System.Management.ManagementClass(statMgmtScope, mgmtPath, null);
                inParams = classObj.GetMethodParameters("SetDatabasePath");
                inParams["DatabasePath"] = ((System.String )(DatabasePath));
                System.Management.ManagementBaseObject outParams = classObj.InvokeMethod("SetDatabasePath", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public static uint SetDeadGWDetect(bool DeadGWDetectEnabled) {
            bool IsMethodStatic = true;
            if ((IsMethodStatic == true)) {
                System.Management.ManagementBaseObject inParams = null;
                System.Management.ManagementPath mgmtPath = new System.Management.ManagementPath(CreatedClassName);
                System.Management.ManagementClass classObj = new System.Management.ManagementClass(statMgmtScope, mgmtPath, null);
                inParams = classObj.GetMethodParameters("SetDeadGWDetect");
                inParams["DeadGWDetectEnabled"] = ((System.Boolean )(DeadGWDetectEnabled));
                System.Management.ManagementBaseObject outParams = classObj.InvokeMethod("SetDeadGWDetect", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public static uint SetDefaultTOS(byte DefaultTOS) {
            bool IsMethodStatic = true;
            if ((IsMethodStatic == true)) {
                System.Management.ManagementBaseObject inParams = null;
                System.Management.ManagementPath mgmtPath = new System.Management.ManagementPath(CreatedClassName);
                System.Management.ManagementClass classObj = new System.Management.ManagementClass(statMgmtScope, mgmtPath, null);
                inParams = classObj.GetMethodParameters("SetDefaultTOS");
                inParams["DefaultTOS"] = ((System.Byte )(DefaultTOS));
                System.Management.ManagementBaseObject outParams = classObj.InvokeMethod("SetDefaultTOS", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public static uint SetDefaultTTL(byte DefaultTTL) {
            bool IsMethodStatic = true;
            if ((IsMethodStatic == true)) {
                System.Management.ManagementBaseObject inParams = null;
                System.Management.ManagementPath mgmtPath = new System.Management.ManagementPath(CreatedClassName);
                System.Management.ManagementClass classObj = new System.Management.ManagementClass(statMgmtScope, mgmtPath, null);
                inParams = classObj.GetMethodParameters("SetDefaultTTL");
                inParams["DefaultTTL"] = ((System.Byte )(DefaultTTL));
                System.Management.ManagementBaseObject outParams = classObj.InvokeMethod("SetDefaultTTL", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public uint SetDNSDomain(string DNSDomain) {
            if ((isEmbedded == false)) {
                System.Management.ManagementBaseObject inParams = null;
                inParams = PrivateLateBoundObject.GetMethodParameters("SetDNSDomain");
                inParams["DNSDomain"] = ((System.String )(DNSDomain));
                System.Management.ManagementBaseObject outParams = PrivateLateBoundObject.InvokeMethod("SetDNSDomain", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public uint SetDNSServerSearchOrder(string[] DNSServerSearchOrder) {
            if ((isEmbedded == false)) {
                System.Management.ManagementBaseObject inParams = null;
                inParams = PrivateLateBoundObject.GetMethodParameters("SetDNSServerSearchOrder");
                inParams["DNSServerSearchOrder"] = ((string[])(DNSServerSearchOrder));
                System.Management.ManagementBaseObject outParams = PrivateLateBoundObject.InvokeMethod("SetDNSServerSearchOrder", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public static uint SetDNSSuffixSearchOrder(string[] DNSDomainSuffixSearchOrder) {
            bool IsMethodStatic = true;
            if ((IsMethodStatic == true)) {
                System.Management.ManagementBaseObject inParams = null;
                System.Management.ManagementPath mgmtPath = new System.Management.ManagementPath(CreatedClassName);
                System.Management.ManagementClass classObj = new System.Management.ManagementClass(statMgmtScope, mgmtPath, null);
                inParams = classObj.GetMethodParameters("SetDNSSuffixSearchOrder");
                inParams["DNSDomainSuffixSearchOrder"] = ((string[])(DNSDomainSuffixSearchOrder));
                System.Management.ManagementBaseObject outParams = classObj.InvokeMethod("SetDNSSuffixSearchOrder", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public uint SetDynamicDNSRegistration(bool DomainDNSRegistrationEnabled, bool FullDNSRegistrationEnabled) {
            if ((isEmbedded == false)) {
                System.Management.ManagementBaseObject inParams = null;
                inParams = PrivateLateBoundObject.GetMethodParameters("SetDynamicDNSRegistration");
                inParams["DomainDNSRegistrationEnabled"] = ((System.Boolean )(DomainDNSRegistrationEnabled));
                inParams["FullDNSRegistrationEnabled"] = ((System.Boolean )(FullDNSRegistrationEnabled));
                System.Management.ManagementBaseObject outParams = PrivateLateBoundObject.InvokeMethod("SetDynamicDNSRegistration", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public static uint SetForwardBufferMemory(uint ForwardBufferMemory) {
            bool IsMethodStatic = true;
            if ((IsMethodStatic == true)) {
                System.Management.ManagementBaseObject inParams = null;
                System.Management.ManagementPath mgmtPath = new System.Management.ManagementPath(CreatedClassName);
                System.Management.ManagementClass classObj = new System.Management.ManagementClass(statMgmtScope, mgmtPath, null);
                inParams = classObj.GetMethodParameters("SetForwardBufferMemory");
                inParams["ForwardBufferMemory"] = ((System.UInt32 )(ForwardBufferMemory));
                System.Management.ManagementBaseObject outParams = classObj.InvokeMethod("SetForwardBufferMemory", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public uint SetGateways(string[] DefaultIPGateway, ushort[] GatewayCostMetric) {
            if ((isEmbedded == false)) {
                System.Management.ManagementBaseObject inParams = null;
                inParams = PrivateLateBoundObject.GetMethodParameters("SetGateways");
                inParams["DefaultIPGateway"] = ((string[])(DefaultIPGateway));
                inParams["GatewayCostMetric"] = ((ushort[])(GatewayCostMetric));
                System.Management.ManagementBaseObject outParams = PrivateLateBoundObject.InvokeMethod("SetGateways", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public static uint SetIGMPLevel(byte IGMPLevel) {
            bool IsMethodStatic = true;
            if ((IsMethodStatic == true)) {
                System.Management.ManagementBaseObject inParams = null;
                System.Management.ManagementPath mgmtPath = new System.Management.ManagementPath(CreatedClassName);
                System.Management.ManagementClass classObj = new System.Management.ManagementClass(statMgmtScope, mgmtPath, null);
                inParams = classObj.GetMethodParameters("SetIGMPLevel");
                inParams["IGMPLevel"] = ((System.Byte )(IGMPLevel));
                System.Management.ManagementBaseObject outParams = classObj.InvokeMethod("SetIGMPLevel", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public uint SetIPConnectionMetric(uint IPConnectionMetric) {
            if ((isEmbedded == false)) {
                System.Management.ManagementBaseObject inParams = null;
                inParams = PrivateLateBoundObject.GetMethodParameters("SetIPConnectionMetric");
                inParams["IPConnectionMetric"] = ((System.UInt32 )(IPConnectionMetric));
                System.Management.ManagementBaseObject outParams = PrivateLateBoundObject.InvokeMethod("SetIPConnectionMetric", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public static uint SetIPUseZeroBroadcast(bool IPUseZeroBroadcast) {
            bool IsMethodStatic = true;
            if ((IsMethodStatic == true)) {
                System.Management.ManagementBaseObject inParams = null;
                System.Management.ManagementPath mgmtPath = new System.Management.ManagementPath(CreatedClassName);
                System.Management.ManagementClass classObj = new System.Management.ManagementClass(statMgmtScope, mgmtPath, null);
                inParams = classObj.GetMethodParameters("SetIPUseZeroBroadcast");
                inParams["IPUseZeroBroadcast"] = ((System.Boolean )(IPUseZeroBroadcast));
                System.Management.ManagementBaseObject outParams = classObj.InvokeMethod("SetIPUseZeroBroadcast", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public uint SetIPXFrameTypeNetworkPairs(uint[] IPXFrameType, string[] IPXNetworkNumber) {
            if ((isEmbedded == false)) {
                System.Management.ManagementBaseObject inParams = null;
                inParams = PrivateLateBoundObject.GetMethodParameters("SetIPXFrameTypeNetworkPairs");
                inParams["IPXFrameType"] = ((uint[])(IPXFrameType));
                inParams["IPXNetworkNumber"] = ((string[])(IPXNetworkNumber));
                System.Management.ManagementBaseObject outParams = PrivateLateBoundObject.InvokeMethod("SetIPXFrameTypeNetworkPairs", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public static uint SetIPXVirtualNetworkNumber(string IPXVirtualNetNumber) {
            bool IsMethodStatic = true;
            if ((IsMethodStatic == true)) {
                System.Management.ManagementBaseObject inParams = null;
                System.Management.ManagementPath mgmtPath = new System.Management.ManagementPath(CreatedClassName);
                System.Management.ManagementClass classObj = new System.Management.ManagementClass(statMgmtScope, mgmtPath, null);
                inParams = classObj.GetMethodParameters("SetIPXVirtualNetworkNumber");
                inParams["IPXVirtualNetNumber"] = ((System.String )(IPXVirtualNetNumber));
                System.Management.ManagementBaseObject outParams = classObj.InvokeMethod("SetIPXVirtualNetworkNumber", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public static uint SetKeepAliveInterval(uint KeepAliveInterval) {
            bool IsMethodStatic = true;
            if ((IsMethodStatic == true)) {
                System.Management.ManagementBaseObject inParams = null;
                System.Management.ManagementPath mgmtPath = new System.Management.ManagementPath(CreatedClassName);
                System.Management.ManagementClass classObj = new System.Management.ManagementClass(statMgmtScope, mgmtPath, null);
                inParams = classObj.GetMethodParameters("SetKeepAliveInterval");
                inParams["KeepAliveInterval"] = ((System.UInt32 )(KeepAliveInterval));
                System.Management.ManagementBaseObject outParams = classObj.InvokeMethod("SetKeepAliveInterval", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public static uint SetKeepAliveTime(uint KeepAliveTime) {
            bool IsMethodStatic = true;
            if ((IsMethodStatic == true)) {
                System.Management.ManagementBaseObject inParams = null;
                System.Management.ManagementPath mgmtPath = new System.Management.ManagementPath(CreatedClassName);
                System.Management.ManagementClass classObj = new System.Management.ManagementClass(statMgmtScope, mgmtPath, null);
                inParams = classObj.GetMethodParameters("SetKeepAliveTime");
                inParams["KeepAliveTime"] = ((System.UInt32 )(KeepAliveTime));
                System.Management.ManagementBaseObject outParams = classObj.InvokeMethod("SetKeepAliveTime", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public static uint SetMTU(uint MTU) {
            bool IsMethodStatic = true;
            if ((IsMethodStatic == true)) {
                System.Management.ManagementBaseObject inParams = null;
                System.Management.ManagementPath mgmtPath = new System.Management.ManagementPath(CreatedClassName);
                System.Management.ManagementClass classObj = new System.Management.ManagementClass(statMgmtScope, mgmtPath, null);
                inParams = classObj.GetMethodParameters("SetMTU");
                inParams["MTU"] = ((System.UInt32 )(MTU));
                System.Management.ManagementBaseObject outParams = classObj.InvokeMethod("SetMTU", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public static uint SetNumForwardPackets(uint NumForwardPackets) {
            bool IsMethodStatic = true;
            if ((IsMethodStatic == true)) {
                System.Management.ManagementBaseObject inParams = null;
                System.Management.ManagementPath mgmtPath = new System.Management.ManagementPath(CreatedClassName);
                System.Management.ManagementClass classObj = new System.Management.ManagementClass(statMgmtScope, mgmtPath, null);
                inParams = classObj.GetMethodParameters("SetNumForwardPackets");
                inParams["NumForwardPackets"] = ((System.UInt32 )(NumForwardPackets));
                System.Management.ManagementBaseObject outParams = classObj.InvokeMethod("SetNumForwardPackets", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public static uint SetPMTUBHDetect(bool PMTUBHDetectEnabled) {
            bool IsMethodStatic = true;
            if ((IsMethodStatic == true)) {
                System.Management.ManagementBaseObject inParams = null;
                System.Management.ManagementPath mgmtPath = new System.Management.ManagementPath(CreatedClassName);
                System.Management.ManagementClass classObj = new System.Management.ManagementClass(statMgmtScope, mgmtPath, null);
                inParams = classObj.GetMethodParameters("SetPMTUBHDetect");
                inParams["PMTUBHDetectEnabled"] = ((System.Boolean )(PMTUBHDetectEnabled));
                System.Management.ManagementBaseObject outParams = classObj.InvokeMethod("SetPMTUBHDetect", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public static uint SetPMTUDiscovery(bool PMTUDiscoveryEnabled) {
            bool IsMethodStatic = true;
            if ((IsMethodStatic == true)) {
                System.Management.ManagementBaseObject inParams = null;
                System.Management.ManagementPath mgmtPath = new System.Management.ManagementPath(CreatedClassName);
                System.Management.ManagementClass classObj = new System.Management.ManagementClass(statMgmtScope, mgmtPath, null);
                inParams = classObj.GetMethodParameters("SetPMTUDiscovery");
                inParams["PMTUDiscoveryEnabled"] = ((System.Boolean )(PMTUDiscoveryEnabled));
                System.Management.ManagementBaseObject outParams = classObj.InvokeMethod("SetPMTUDiscovery", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public uint SetTcpipNetbios(uint TcpipNetbiosOptions) {
            if ((isEmbedded == false)) {
                System.Management.ManagementBaseObject inParams = null;
                inParams = PrivateLateBoundObject.GetMethodParameters("SetTcpipNetbios");
                inParams["TcpipNetbiosOptions"] = ((System.UInt32 )(TcpipNetbiosOptions));
                System.Management.ManagementBaseObject outParams = PrivateLateBoundObject.InvokeMethod("SetTcpipNetbios", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public static uint SetTcpMaxConnectRetransmissions(uint TcpMaxConnectRetransmissions) {
            bool IsMethodStatic = true;
            if ((IsMethodStatic == true)) {
                System.Management.ManagementBaseObject inParams = null;
                System.Management.ManagementPath mgmtPath = new System.Management.ManagementPath(CreatedClassName);
                System.Management.ManagementClass classObj = new System.Management.ManagementClass(statMgmtScope, mgmtPath, null);
                inParams = classObj.GetMethodParameters("SetTcpMaxConnectRetransmissions");
                inParams["TcpMaxConnectRetransmissions"] = ((System.UInt32 )(TcpMaxConnectRetransmissions));
                System.Management.ManagementBaseObject outParams = classObj.InvokeMethod("SetTcpMaxConnectRetransmissions", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public static uint SetTcpMaxDataRetransmissions(uint TcpMaxDataRetransmissions) {
            bool IsMethodStatic = true;
            if ((IsMethodStatic == true)) {
                System.Management.ManagementBaseObject inParams = null;
                System.Management.ManagementPath mgmtPath = new System.Management.ManagementPath(CreatedClassName);
                System.Management.ManagementClass classObj = new System.Management.ManagementClass(statMgmtScope, mgmtPath, null);
                inParams = classObj.GetMethodParameters("SetTcpMaxDataRetransmissions");
                inParams["TcpMaxDataRetransmissions"] = ((System.UInt32 )(TcpMaxDataRetransmissions));
                System.Management.ManagementBaseObject outParams = classObj.InvokeMethod("SetTcpMaxDataRetransmissions", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public static uint SetTcpNumConnections(uint TcpNumConnections) {
            bool IsMethodStatic = true;
            if ((IsMethodStatic == true)) {
                System.Management.ManagementBaseObject inParams = null;
                System.Management.ManagementPath mgmtPath = new System.Management.ManagementPath(CreatedClassName);
                System.Management.ManagementClass classObj = new System.Management.ManagementClass(statMgmtScope, mgmtPath, null);
                inParams = classObj.GetMethodParameters("SetTcpNumConnections");
                inParams["TcpNumConnections"] = ((System.UInt32 )(TcpNumConnections));
                System.Management.ManagementBaseObject outParams = classObj.InvokeMethod("SetTcpNumConnections", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public static uint SetTcpUseRFC1122UrgentPointer(bool TcpUseRFC1122UrgentPointer) {
            bool IsMethodStatic = true;
            if ((IsMethodStatic == true)) {
                System.Management.ManagementBaseObject inParams = null;
                System.Management.ManagementPath mgmtPath = new System.Management.ManagementPath(CreatedClassName);
                System.Management.ManagementClass classObj = new System.Management.ManagementClass(statMgmtScope, mgmtPath, null);
                inParams = classObj.GetMethodParameters("SetTcpUseRFC1122UrgentPointer");
                inParams["TcpUseRFC1122UrgentPointer"] = ((System.Boolean )(TcpUseRFC1122UrgentPointer));
                System.Management.ManagementBaseObject outParams = classObj.InvokeMethod("SetTcpUseRFC1122UrgentPointer", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public static uint SetTcpWindowSize(ushort TcpWindowSize) {
            bool IsMethodStatic = true;
            if ((IsMethodStatic == true)) {
                System.Management.ManagementBaseObject inParams = null;
                System.Management.ManagementPath mgmtPath = new System.Management.ManagementPath(CreatedClassName);
                System.Management.ManagementClass classObj = new System.Management.ManagementClass(statMgmtScope, mgmtPath, null);
                inParams = classObj.GetMethodParameters("SetTcpWindowSize");
                inParams["TcpWindowSize"] = ((System.UInt16 )(TcpWindowSize));
                System.Management.ManagementBaseObject outParams = classObj.InvokeMethod("SetTcpWindowSize", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public uint SetWINSServer(string WINSPrimaryServer, string WINSSecondaryServer) {
            if ((isEmbedded == false)) {
                System.Management.ManagementBaseObject inParams = null;
                inParams = PrivateLateBoundObject.GetMethodParameters("SetWINSServer");
                inParams["WINSPrimaryServer"] = ((System.String )(WINSPrimaryServer));
                inParams["WINSSecondaryServer"] = ((System.String )(WINSSecondaryServer));
                System.Management.ManagementBaseObject outParams = PrivateLateBoundObject.InvokeMethod("SetWINSServer", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public enum IGMPLevelValues {
            
            Nessun_multicast = 0,
            
            Multicast_IP = 1,
            
            Multicast_IP_e_IGMP = 2,
            
            NULL_ENUM_VALUE = 3,
        }
        
        public enum IPXFrameTypeValues {
            
            Ethernet_II = 0,
            
            Ethernet_802_3 = 1,
            
            Ethernet_802_2 = 2,
            
            Ethernet_SNAP = 3,
            
            Automatico = 255,
            
            NULL_ENUM_VALUE = 256,
        }
        
        public enum IPXMediaTypeValues {
            
            Ethernet = 1,
            
            Token_Ring = 2,
            
            FDDI = 3,
            
            ARCNET = 8,
            
            NULL_ENUM_VALUE = 0,
        }
        
        public enum TcpipNetbiosOptionsValues {
            
            EnableNetbiosViaDhcp = 0,
            
            EnableNetbios = 1,
            
            DisableNetbios = 2,
            
            NULL_ENUM_VALUE = 3,
        }
        
        // Enumerator implementation for enumerating instances of the class.
        public class NetworkAdapterConfigurationCollection : object, ICollection {
            
            private ManagementObjectCollection privColObj;
            
            public NetworkAdapterConfigurationCollection(ManagementObjectCollection objCollection) {
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
                    array.SetValue(new WmiNetworkAdapterConfiguration(((System.Management.ManagementObject)(array.GetValue(nCtr)))), nCtr);
                }
            }
            
            public virtual System.Collections.IEnumerator GetEnumerator() {
                return new NetworkAdapterConfigurationEnumerator(privColObj.GetEnumerator());
            }
            
            public class NetworkAdapterConfigurationEnumerator : object, System.Collections.IEnumerator {
                
                private ManagementObjectCollection.ManagementObjectEnumerator privObjEnum;
                
                public NetworkAdapterConfigurationEnumerator(ManagementObjectCollection.ManagementObjectEnumerator objEnum) {
                    privObjEnum = objEnum;
                }
                
                public virtual object Current {
                    get {
                        return new WmiNetworkAdapterConfiguration(((System.Management.ManagementObject)(privObjEnum.Current)));
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
