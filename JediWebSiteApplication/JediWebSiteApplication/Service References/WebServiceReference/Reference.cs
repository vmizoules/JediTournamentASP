﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JediWebSiteApplication.WebServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="JediContract", Namespace="http://schemas.datacontract.org/2004/07/JediService.Models")]
    [System.SerializableAttribute()]
    public partial class JediContract : JediWebSiteApplication.WebServiceReference.EntityContract {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private JediWebSiteApplication.WebServiceReference.CaracteristiqueContract[] CaracteristiquesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsSithField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public JediWebSiteApplication.WebServiceReference.CaracteristiqueContract[] Caracteristiques {
            get {
                return this.CaracteristiquesField;
            }
            set {
                if ((object.ReferenceEquals(this.CaracteristiquesField, value) != true)) {
                    this.CaracteristiquesField = value;
                    this.RaisePropertyChanged("Caracteristiques");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsSith {
            get {
                return this.IsSithField;
            }
            set {
                if ((this.IsSithField.Equals(value) != true)) {
                    this.IsSithField = value;
                    this.RaisePropertyChanged("IsSith");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nom {
            get {
                return this.NomField;
            }
            set {
                if ((object.ReferenceEquals(this.NomField, value) != true)) {
                    this.NomField = value;
                    this.RaisePropertyChanged("Nom");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EntityContract", Namespace="http://schemas.datacontract.org/2004/07/JediService.Models")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(JediWebSiteApplication.WebServiceReference.StadeContract))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(JediWebSiteApplication.WebServiceReference.MatchContract))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(JediWebSiteApplication.WebServiceReference.TournoiContract))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(JediWebSiteApplication.WebServiceReference.JediContract))]
    public partial class EntityContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StadeContract", Namespace="http://schemas.datacontract.org/2004/07/JediService.Models")]
    [System.SerializableAttribute()]
    public partial class StadeContract : JediWebSiteApplication.WebServiceReference.EntityContract {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private JediWebSiteApplication.WebServiceReference.CaracteristiqueContract[] CaracteristiquesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NbPlacesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PlaneteField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public JediWebSiteApplication.WebServiceReference.CaracteristiqueContract[] Caracteristiques {
            get {
                return this.CaracteristiquesField;
            }
            set {
                if ((object.ReferenceEquals(this.CaracteristiquesField, value) != true)) {
                    this.CaracteristiquesField = value;
                    this.RaisePropertyChanged("Caracteristiques");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NbPlaces {
            get {
                return this.NbPlacesField;
            }
            set {
                if ((this.NbPlacesField.Equals(value) != true)) {
                    this.NbPlacesField = value;
                    this.RaisePropertyChanged("NbPlaces");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nom {
            get {
                return this.NomField;
            }
            set {
                if ((object.ReferenceEquals(this.NomField, value) != true)) {
                    this.NomField = value;
                    this.RaisePropertyChanged("Nom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Planete {
            get {
                return this.PlaneteField;
            }
            set {
                if ((object.ReferenceEquals(this.PlaneteField, value) != true)) {
                    this.PlaneteField = value;
                    this.RaisePropertyChanged("Planete");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MatchContract", Namespace="http://schemas.datacontract.org/2004/07/JediService.Models")]
    [System.SerializableAttribute()]
    public partial class MatchContract : JediWebSiteApplication.WebServiceReference.EntityContract {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdVainqueurField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private JediWebSiteApplication.WebServiceReference.JediContract Jedi1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private JediWebSiteApplication.WebServiceReference.JediContract Jedi2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private JediWebSiteApplication.WebServiceReference.EPhaseTournoiContract PhaseTournoiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private JediWebSiteApplication.WebServiceReference.StadeContract StadeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdVainqueur {
            get {
                return this.IdVainqueurField;
            }
            set {
                if ((this.IdVainqueurField.Equals(value) != true)) {
                    this.IdVainqueurField = value;
                    this.RaisePropertyChanged("IdVainqueur");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public JediWebSiteApplication.WebServiceReference.JediContract Jedi1 {
            get {
                return this.Jedi1Field;
            }
            set {
                if ((object.ReferenceEquals(this.Jedi1Field, value) != true)) {
                    this.Jedi1Field = value;
                    this.RaisePropertyChanged("Jedi1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public JediWebSiteApplication.WebServiceReference.JediContract Jedi2 {
            get {
                return this.Jedi2Field;
            }
            set {
                if ((object.ReferenceEquals(this.Jedi2Field, value) != true)) {
                    this.Jedi2Field = value;
                    this.RaisePropertyChanged("Jedi2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public JediWebSiteApplication.WebServiceReference.EPhaseTournoiContract PhaseTournoi {
            get {
                return this.PhaseTournoiField;
            }
            set {
                if ((this.PhaseTournoiField.Equals(value) != true)) {
                    this.PhaseTournoiField = value;
                    this.RaisePropertyChanged("PhaseTournoi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public JediWebSiteApplication.WebServiceReference.StadeContract Stade {
            get {
                return this.StadeField;
            }
            set {
                if ((object.ReferenceEquals(this.StadeField, value) != true)) {
                    this.StadeField = value;
                    this.RaisePropertyChanged("Stade");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TournoiContract", Namespace="http://schemas.datacontract.org/2004/07/JediService.Models")]
    [System.SerializableAttribute()]
    public partial class TournoiContract : JediWebSiteApplication.WebServiceReference.EntityContract {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private JediWebSiteApplication.WebServiceReference.MatchContract[] MatchsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public JediWebSiteApplication.WebServiceReference.MatchContract[] Matchs {
            get {
                return this.MatchsField;
            }
            set {
                if ((object.ReferenceEquals(this.MatchsField, value) != true)) {
                    this.MatchsField = value;
                    this.RaisePropertyChanged("Matchs");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nom {
            get {
                return this.NomField;
            }
            set {
                if ((object.ReferenceEquals(this.NomField, value) != true)) {
                    this.NomField = value;
                    this.RaisePropertyChanged("Nom");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CaracteristiqueContract", Namespace="http://schemas.datacontract.org/2004/07/JediService.Models")]
    [System.SerializableAttribute()]
    public partial class CaracteristiqueContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private JediWebSiteApplication.WebServiceReference.EDefCaracteristiqueContract DefinitionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private JediWebSiteApplication.WebServiceReference.ETypeCaracteristiqueContract TypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ValeurField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public JediWebSiteApplication.WebServiceReference.EDefCaracteristiqueContract Definition {
            get {
                return this.DefinitionField;
            }
            set {
                if ((this.DefinitionField.Equals(value) != true)) {
                    this.DefinitionField = value;
                    this.RaisePropertyChanged("Definition");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nom {
            get {
                return this.NomField;
            }
            set {
                if ((object.ReferenceEquals(this.NomField, value) != true)) {
                    this.NomField = value;
                    this.RaisePropertyChanged("Nom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public JediWebSiteApplication.WebServiceReference.ETypeCaracteristiqueContract Type {
            get {
                return this.TypeField;
            }
            set {
                if ((this.TypeField.Equals(value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Valeur {
            get {
                return this.ValeurField;
            }
            set {
                if ((this.ValeurField.Equals(value) != true)) {
                    this.ValeurField = value;
                    this.RaisePropertyChanged("Valeur");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EDefCaracteristiqueContract", Namespace="http://schemas.datacontract.org/2004/07/JediService.Models")]
    public enum EDefCaracteristiqueContract : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Force = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Defense = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Sante = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Chance = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ETypeCaracteristiqueContract", Namespace="http://schemas.datacontract.org/2004/07/JediService.Models")]
    public enum ETypeCaracteristiqueContract : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Jedi = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Stade = 1,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EPhaseTournoiContract", Namespace="http://schemas.datacontract.org/2004/07/JediService.Models")]
    public enum EPhaseTournoiContract : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        QuartFinale = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DemiFinale = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Finale = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WebServiceReference.IJediWebService")]
    public interface IJediWebService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJediWebService/GetJedis", ReplyAction="http://tempuri.org/IJediWebService/GetJedisResponse")]
        JediWebSiteApplication.WebServiceReference.JediContract[] GetJedis();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJediWebService/GetJedis", ReplyAction="http://tempuri.org/IJediWebService/GetJedisResponse")]
        System.Threading.Tasks.Task<JediWebSiteApplication.WebServiceReference.JediContract[]> GetJedisAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJediWebService/CreateJedi", ReplyAction="http://tempuri.org/IJediWebService/CreateJediResponse")]
        void CreateJedi(JediWebSiteApplication.WebServiceReference.JediContract jedi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJediWebService/CreateJedi", ReplyAction="http://tempuri.org/IJediWebService/CreateJediResponse")]
        System.Threading.Tasks.Task CreateJediAsync(JediWebSiteApplication.WebServiceReference.JediContract jedi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJediWebService/UpdateJedi", ReplyAction="http://tempuri.org/IJediWebService/UpdateJediResponse")]
        void UpdateJedi(JediWebSiteApplication.WebServiceReference.JediContract jedi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJediWebService/UpdateJedi", ReplyAction="http://tempuri.org/IJediWebService/UpdateJediResponse")]
        System.Threading.Tasks.Task UpdateJediAsync(JediWebSiteApplication.WebServiceReference.JediContract jedi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJediWebService/DeleteJedi", ReplyAction="http://tempuri.org/IJediWebService/DeleteJediResponse")]
        void DeleteJedi(JediWebSiteApplication.WebServiceReference.JediContract jedi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJediWebService/DeleteJedi", ReplyAction="http://tempuri.org/IJediWebService/DeleteJediResponse")]
        System.Threading.Tasks.Task DeleteJediAsync(JediWebSiteApplication.WebServiceReference.JediContract jedi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJediWebService/GetCaracteristiques", ReplyAction="http://tempuri.org/IJediWebService/GetCaracteristiquesResponse")]
        JediWebSiteApplication.WebServiceReference.CaracteristiqueContract[] GetCaracteristiques(int jediID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJediWebService/GetCaracteristiques", ReplyAction="http://tempuri.org/IJediWebService/GetCaracteristiquesResponse")]
        System.Threading.Tasks.Task<JediWebSiteApplication.WebServiceReference.CaracteristiqueContract[]> GetCaracteristiquesAsync(int jediID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJediWebService/CreateStade", ReplyAction="http://tempuri.org/IJediWebService/CreateStadeResponse")]
        void CreateStade(JediWebSiteApplication.WebServiceReference.StadeContract stade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJediWebService/CreateStade", ReplyAction="http://tempuri.org/IJediWebService/CreateStadeResponse")]
        System.Threading.Tasks.Task CreateStadeAsync(JediWebSiteApplication.WebServiceReference.StadeContract stade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJediWebService/UpdateStade", ReplyAction="http://tempuri.org/IJediWebService/UpdateStadeResponse")]
        void UpdateStade(JediWebSiteApplication.WebServiceReference.StadeContract stade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJediWebService/UpdateStade", ReplyAction="http://tempuri.org/IJediWebService/UpdateStadeResponse")]
        System.Threading.Tasks.Task UpdateStadeAsync(JediWebSiteApplication.WebServiceReference.StadeContract stade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJediWebService/DeleteStade", ReplyAction="http://tempuri.org/IJediWebService/DeleteStadeResponse")]
        void DeleteStade(JediWebSiteApplication.WebServiceReference.StadeContract stade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJediWebService/DeleteStade", ReplyAction="http://tempuri.org/IJediWebService/DeleteStadeResponse")]
        System.Threading.Tasks.Task DeleteStadeAsync(JediWebSiteApplication.WebServiceReference.StadeContract stade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJediWebService/GetStades", ReplyAction="http://tempuri.org/IJediWebService/GetStadesResponse")]
        JediWebSiteApplication.WebServiceReference.StadeContract[] GetStades();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJediWebService/GetStades", ReplyAction="http://tempuri.org/IJediWebService/GetStadesResponse")]
        System.Threading.Tasks.Task<JediWebSiteApplication.WebServiceReference.StadeContract[]> GetStadesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJediWebService/CreateMatch", ReplyAction="http://tempuri.org/IJediWebService/CreateMatchResponse")]
        void CreateMatch(JediWebSiteApplication.WebServiceReference.MatchContract match);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJediWebService/CreateMatch", ReplyAction="http://tempuri.org/IJediWebService/CreateMatchResponse")]
        System.Threading.Tasks.Task CreateMatchAsync(JediWebSiteApplication.WebServiceReference.MatchContract match);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJediWebService/UpdateMatch", ReplyAction="http://tempuri.org/IJediWebService/UpdateMatchResponse")]
        void UpdateMatch(JediWebSiteApplication.WebServiceReference.MatchContract match);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJediWebService/UpdateMatch", ReplyAction="http://tempuri.org/IJediWebService/UpdateMatchResponse")]
        System.Threading.Tasks.Task UpdateMatchAsync(JediWebSiteApplication.WebServiceReference.MatchContract match);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJediWebService/DeleteMatch", ReplyAction="http://tempuri.org/IJediWebService/DeleteMatchResponse")]
        void DeleteMatch(JediWebSiteApplication.WebServiceReference.MatchContract match);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJediWebService/DeleteMatch", ReplyAction="http://tempuri.org/IJediWebService/DeleteMatchResponse")]
        System.Threading.Tasks.Task DeleteMatchAsync(JediWebSiteApplication.WebServiceReference.MatchContract match);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJediWebService/GetMatchs", ReplyAction="http://tempuri.org/IJediWebService/GetMatchsResponse")]
        JediWebSiteApplication.WebServiceReference.MatchContract[] GetMatchs();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJediWebService/GetMatchs", ReplyAction="http://tempuri.org/IJediWebService/GetMatchsResponse")]
        System.Threading.Tasks.Task<JediWebSiteApplication.WebServiceReference.MatchContract[]> GetMatchsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJediWebService/CreateTournoi", ReplyAction="http://tempuri.org/IJediWebService/CreateTournoiResponse")]
        void CreateTournoi(JediWebSiteApplication.WebServiceReference.TournoiContract tournoi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJediWebService/CreateTournoi", ReplyAction="http://tempuri.org/IJediWebService/CreateTournoiResponse")]
        System.Threading.Tasks.Task CreateTournoiAsync(JediWebSiteApplication.WebServiceReference.TournoiContract tournoi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJediWebService/DeleteTournoi", ReplyAction="http://tempuri.org/IJediWebService/DeleteTournoiResponse")]
        void DeleteTournoi(JediWebSiteApplication.WebServiceReference.TournoiContract tournoi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJediWebService/DeleteTournoi", ReplyAction="http://tempuri.org/IJediWebService/DeleteTournoiResponse")]
        System.Threading.Tasks.Task DeleteTournoiAsync(JediWebSiteApplication.WebServiceReference.TournoiContract tournoi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJediWebService/GetTournois", ReplyAction="http://tempuri.org/IJediWebService/GetTournoisResponse")]
        JediWebSiteApplication.WebServiceReference.TournoiContract[] GetTournois();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJediWebService/GetTournois", ReplyAction="http://tempuri.org/IJediWebService/GetTournoisResponse")]
        System.Threading.Tasks.Task<JediWebSiteApplication.WebServiceReference.TournoiContract[]> GetTournoisAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IJediWebServiceChannel : JediWebSiteApplication.WebServiceReference.IJediWebService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class JediWebServiceClient : System.ServiceModel.ClientBase<JediWebSiteApplication.WebServiceReference.IJediWebService>, JediWebSiteApplication.WebServiceReference.IJediWebService {
        
        public JediWebServiceClient() {
        }
        
        public JediWebServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public JediWebServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public JediWebServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public JediWebServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public JediWebSiteApplication.WebServiceReference.JediContract[] GetJedis() {
            return base.Channel.GetJedis();
        }
        
        public System.Threading.Tasks.Task<JediWebSiteApplication.WebServiceReference.JediContract[]> GetJedisAsync() {
            return base.Channel.GetJedisAsync();
        }
        
        public void CreateJedi(JediWebSiteApplication.WebServiceReference.JediContract jedi) {
            base.Channel.CreateJedi(jedi);
        }
        
        public System.Threading.Tasks.Task CreateJediAsync(JediWebSiteApplication.WebServiceReference.JediContract jedi) {
            return base.Channel.CreateJediAsync(jedi);
        }
        
        public void UpdateJedi(JediWebSiteApplication.WebServiceReference.JediContract jedi) {
            base.Channel.UpdateJedi(jedi);
        }
        
        public System.Threading.Tasks.Task UpdateJediAsync(JediWebSiteApplication.WebServiceReference.JediContract jedi) {
            return base.Channel.UpdateJediAsync(jedi);
        }
        
        public void DeleteJedi(JediWebSiteApplication.WebServiceReference.JediContract jedi) {
            base.Channel.DeleteJedi(jedi);
        }
        
        public System.Threading.Tasks.Task DeleteJediAsync(JediWebSiteApplication.WebServiceReference.JediContract jedi) {
            return base.Channel.DeleteJediAsync(jedi);
        }
        
        public JediWebSiteApplication.WebServiceReference.CaracteristiqueContract[] GetCaracteristiques(int jediID) {
            return base.Channel.GetCaracteristiques(jediID);
        }
        
        public System.Threading.Tasks.Task<JediWebSiteApplication.WebServiceReference.CaracteristiqueContract[]> GetCaracteristiquesAsync(int jediID) {
            return base.Channel.GetCaracteristiquesAsync(jediID);
        }
        
        public void CreateStade(JediWebSiteApplication.WebServiceReference.StadeContract stade) {
            base.Channel.CreateStade(stade);
        }
        
        public System.Threading.Tasks.Task CreateStadeAsync(JediWebSiteApplication.WebServiceReference.StadeContract stade) {
            return base.Channel.CreateStadeAsync(stade);
        }
        
        public void UpdateStade(JediWebSiteApplication.WebServiceReference.StadeContract stade) {
            base.Channel.UpdateStade(stade);
        }
        
        public System.Threading.Tasks.Task UpdateStadeAsync(JediWebSiteApplication.WebServiceReference.StadeContract stade) {
            return base.Channel.UpdateStadeAsync(stade);
        }
        
        public void DeleteStade(JediWebSiteApplication.WebServiceReference.StadeContract stade) {
            base.Channel.DeleteStade(stade);
        }
        
        public System.Threading.Tasks.Task DeleteStadeAsync(JediWebSiteApplication.WebServiceReference.StadeContract stade) {
            return base.Channel.DeleteStadeAsync(stade);
        }
        
        public JediWebSiteApplication.WebServiceReference.StadeContract[] GetStades() {
            return base.Channel.GetStades();
        }
        
        public System.Threading.Tasks.Task<JediWebSiteApplication.WebServiceReference.StadeContract[]> GetStadesAsync() {
            return base.Channel.GetStadesAsync();
        }
        
        public void CreateMatch(JediWebSiteApplication.WebServiceReference.MatchContract match) {
            base.Channel.CreateMatch(match);
        }
        
        public System.Threading.Tasks.Task CreateMatchAsync(JediWebSiteApplication.WebServiceReference.MatchContract match) {
            return base.Channel.CreateMatchAsync(match);
        }
        
        public void UpdateMatch(JediWebSiteApplication.WebServiceReference.MatchContract match) {
            base.Channel.UpdateMatch(match);
        }
        
        public System.Threading.Tasks.Task UpdateMatchAsync(JediWebSiteApplication.WebServiceReference.MatchContract match) {
            return base.Channel.UpdateMatchAsync(match);
        }
        
        public void DeleteMatch(JediWebSiteApplication.WebServiceReference.MatchContract match) {
            base.Channel.DeleteMatch(match);
        }
        
        public System.Threading.Tasks.Task DeleteMatchAsync(JediWebSiteApplication.WebServiceReference.MatchContract match) {
            return base.Channel.DeleteMatchAsync(match);
        }
        
        public JediWebSiteApplication.WebServiceReference.MatchContract[] GetMatchs() {
            return base.Channel.GetMatchs();
        }
        
        public System.Threading.Tasks.Task<JediWebSiteApplication.WebServiceReference.MatchContract[]> GetMatchsAsync() {
            return base.Channel.GetMatchsAsync();
        }
        
        public void CreateTournoi(JediWebSiteApplication.WebServiceReference.TournoiContract tournoi) {
            base.Channel.CreateTournoi(tournoi);
        }
        
        public System.Threading.Tasks.Task CreateTournoiAsync(JediWebSiteApplication.WebServiceReference.TournoiContract tournoi) {
            return base.Channel.CreateTournoiAsync(tournoi);
        }
        
        public void DeleteTournoi(JediWebSiteApplication.WebServiceReference.TournoiContract tournoi) {
            base.Channel.DeleteTournoi(tournoi);
        }
        
        public System.Threading.Tasks.Task DeleteTournoiAsync(JediWebSiteApplication.WebServiceReference.TournoiContract tournoi) {
            return base.Channel.DeleteTournoiAsync(tournoi);
        }
        
        public JediWebSiteApplication.WebServiceReference.TournoiContract[] GetTournois() {
            return base.Channel.GetTournois();
        }
        
        public System.Threading.Tasks.Task<JediWebSiteApplication.WebServiceReference.TournoiContract[]> GetTournoisAsync() {
            return base.Channel.GetTournoisAsync();
        }
    }
}
