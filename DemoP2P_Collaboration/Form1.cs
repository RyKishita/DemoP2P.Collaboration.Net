using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.PeerToPeer;
using System.Net.PeerToPeer.Collaboration;

namespace DemoP2P_Collaboration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            PeerCollaboration.ContactManager.CreateContactCompleted += ContactManager_CreateContactCompleted;
        }

        Guid id = new Guid("52C1F713-3752-4611-B378-5D5D19D41D3C");
        PeerObject peerObject = null;

        bool PeerOpened
        {
            get
            {
                return peerObject != null;
            }
        }

        #region 入力

        PeerScope PeerScope
        {
            get
            {
                if (radioButtonPeerScopeAll.Checked) return PeerScope.All;
                if (radioButtonPeerScopeInternet.Checked) return PeerScope.Internet;
                if (radioButtonPeerScopeNearMe.Checked) return PeerScope.NearMe;
                if (radioButtonPeerScopeNone.Checked) return PeerScope.None;
                throw new NotImplementedException();
            }
        }

        byte[] Data
        {
            get
            {
                string data = textBoxData.Text.Trim();
                return Encoding.Unicode.GetBytes(data);
            }
        }

        #endregion

        private void SetupPeer()
        {
            peerObject = new PeerObject()
            {
                Id = id,
                PeerScope = PeerScope
            };
        }

        void PeerNearMe_PeerNearMeChanged(object sender, PeerNearMeChangedEventArgs e)
        {
            var peerNearMe = e.PeerNearMe;
            if (peerNearMe == null) return;

            switch (e.PeerChangeType)
            {
                case PeerChangeType.Added:
                    peerNearMe.RefreshDataCompleted += peerNearMe_RefreshDataCompleted;
                    peerNearMe.RefreshDataAsync("Added");
                    AddLog("[Added]PeerNearMe_PeerNearMeChanged", LogType.System);
                    break;
                case PeerChangeType.Deleted:
                    peerNearMe.RefreshDataCompleted -= peerNearMe_RefreshDataCompleted;
                    AddLog("[Deleted]PeerNearMe_PeerNearMeChanged", LogType.System);
                    break;
                case PeerChangeType.Updated:
                    peerNearMe.RefreshDataAsync("Updated");
                    AddLog("[Updated]PeerNearMe_PeerNearMeChanged", LogType.System);
                    break;
                default: throw new NotImplementedException();
            }
        }

        void peerNearMe_RefreshDataCompleted(object sender, RefreshDataCompletedEventArgs e)
        {
            var peerNearMe = sender as PeerNearMe;

            switch (e.UserState.ToString())
            {
                case "Setup":
                    foreach (PeerObject peerObject in peerNearMe.GetObjects(id))
                    {
                        AddLog(peerNearMe, peerObject);
                    }
                    AddLog("[Setup]PeerNearMe_RefreshDataCompleted", LogType.System);
                    break;
                case "Added":
                    foreach (PeerObject peerObject in peerNearMe.GetObjects(id))
                    {
                        AddLog(peerNearMe, peerObject);
                    }
                    AddLog("[Added]PeerNearMe_RefreshDataCompleted", LogType.System);
                    break;
                case "Updated":
                    foreach (PeerObject peerObject in peerNearMe.GetObjects(id))
                    {
                        AddLog(peerNearMe, peerObject);
                    }
                    AddLog("[Updated]PeerNearMe_RefreshDataCompleted", LogType.System);
                    break;
            }

            PeerCollaboration.ContactManager.CreateContactAsync(peerNearMe, e.UserState);
        }

        void ContactManager_CreateContactCompleted(object sender, CreateContactCompletedEventArgs e)
        {
            switch (e.UserState.ToString())
            {
                case "Setup":
                    try
                    {
                        PeerContact existContact = PeerCollaboration.ContactManager.GetContact(e.PeerContact.PeerName);
                        PeerCollaboration.ContactManager.UpdateContact(e.PeerContact);
                    }
                    catch (PeerToPeerException ex)
                    {
                        AddLog("ContactManager_CreateContactCompleted:" + ex.Message, LogType.System);
                        PeerCollaboration.ContactManager.AddContact(e.PeerContact);
                    }
                    e.PeerContact.SubscribeCompleted += peerContact_SubscribeCompleted;
                    e.PeerContact.SubscribeAsync(peerObject);
                    AddLog("[Setup]ContactManager_CreateContactCompleted", LogType.System);
                    break;
                case "Added":
                    try
                    {
                        PeerContact existContact = PeerCollaboration.ContactManager.GetContact(e.PeerContact.PeerName);
                        PeerCollaboration.ContactManager.UpdateContact(e.PeerContact);
                    }
                    catch (PeerToPeerException ex)
                    {
                        AddLog("ContactManager_CreateContactCompleted:" + ex.Message, LogType.System);
                        PeerCollaboration.ContactManager.AddContact(e.PeerContact);
                    }
                    e.PeerContact.SubscribeCompleted += peerContact_SubscribeCompleted;
                    e.PeerContact.SubscribeAsync(peerObject);
                    AddLog("[Added]ContactManager_CreateContactCompleted", LogType.System);
                    break;
                case "Deleted":
                    e.PeerContact.SubscribeCompleted -= peerContact_SubscribeCompleted;
                    PeerCollaboration.ContactManager.DeleteContact(e.PeerContact);
                    AddLog("[Deleted]ContactManager_CreateContactCompleted", LogType.System);
                    break;
            }
        }

        void peerContact_SubscribeCompleted(object sender, SubscribeCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                AddLog("[Cancelled]peerContact_SubscribeCompleted", LogType.System);
            }
            else
            {
                AddLog("peerContact_SubscribeCompleted", LogType.System);
            }
        }

        void peerObject_ObjectChanged(object sender, ObjectChangedEventArgs e)
        {
            switch (e.PeerChangeType)
            {
                case PeerChangeType.Added:
                    AddLog("[Added]peerObject_ObjectChanged", LogType.System);
                    e.PeerObject.ObjectChanged +=  peerObject_ObjectChanged;
                    AddLog(e.PeerContact, e.PeerObject);
                    break;
                case PeerChangeType.Deleted:
                    AddLog("[Deleted]peerObject_ObjectChanged", LogType.System);
                    e.PeerObject.ObjectChanged -=  peerObject_ObjectChanged;
                    break;
                case PeerChangeType.Updated:
                    AddLog("[Updated]peerObject_ObjectChanged", LogType.System);
                    AddLog(e.PeerContact, e.PeerObject);
                    break;
            }
        }

        private void UpdateUI()
        {
            radioButtonPeerScopeAll.Enabled = !PeerOpened;
            radioButtonPeerScopeInternet.Enabled = !PeerOpened;
            radioButtonPeerScopeNearMe.Enabled = !PeerOpened;
            radioButtonPeerScopeNone.Enabled = !PeerOpened;

            buttonStartOrUpdate.Text = PeerOpened ? "更新" : "開始";
            buttonClose.Enabled = PeerOpened;
            buttonLoad.Enabled = PeerOpened;
        }

        private void SetSendData()
        {
            peerObject.Data = Data;
            try
            {
                PeerCollaboration.SetObject(peerObject);
                AddLog(ContactManager.LocalContact.Nickname, Data, LogType.Send);
            }
            catch (Exception ex)
            {
                AddLog("SetSendData:" + ex.Message, LogType.System);
            }
        }

        private void ClosePeer()
        {
            if (!PeerOpened) return;

            PeerNearMe.PeerNearMeChanged -= PeerNearMe_PeerNearMeChanged;
            PeerCollaboration.SignOut(PeerScope);
            peerObject.Dispose();
            peerObject = null;
        }

        private void buttonStartOrUpdate_Click(object sender, EventArgs e)
        {
            if (PeerOpened)
            {
                AddLog("UpdateSend", LogType.System);
                SetSendData();
            }
            else
            {
                try
                {
                    PeerCollaboration.SignIn(PeerScope);
                }
                catch (PeerToPeerException ex)
                {
                    AddLog("SignIn:" + ex.Message, LogType.System);
                    return;
                }
                SetupPeer();
                UpdateUI();

                PeerNearMe.PeerNearMeChanged += PeerNearMe_PeerNearMeChanged;

                AddLog("StartPeer", LogType.System);
                SetSendData();

                //buttonLoad.PerformClick();

                PeerNearMeCollection peerNearMeCollection = PeerCollaboration.GetPeersNearMe();
                foreach (PeerNearMe peerNearMe in peerNearMeCollection)
                {
                    peerNearMe.RefreshDataCompleted += peerNearMe_RefreshDataCompleted;
                    peerNearMe.RefreshDataAsync("Setup");
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClosePeer();
            PeerCollaboration.ContactManager.CreateContactCompleted -= ContactManager_CreateContactCompleted;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            ClosePeer();
            UpdateUI();
            AddLog("ClosePeer", LogType.System);
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            PeerNearMeCollection peerNearMeCollection = PeerCollaboration.GetPeersNearMe();
            foreach (PeerNearMe peerNearMe in peerNearMeCollection)
            {
                peerNearMe.RefreshDataAsync("Load");
            }
        }

        #region AddLog

        enum LogType
        {
            System,
            Send,
            Received,
        }

        void AddLog(PeerNearMe peerNearMe, PeerObject peerObject)
        {
            AddLog(peerNearMe.Nickname, peerObject);
        }

        void AddLog(PeerContact peerContact, PeerObject peerObject)
        {
            AddLog(peerContact.Nickname, peerObject);
        }
        void AddLog(string nickname, PeerObject peerObject)
        {
            AddLog(nickname, peerObject.Data, LogType.Received);
        }

        void AddLog(string comment, byte[] data, LogType logType)
        {
            string dataText = Encoding.Unicode.GetString(data);
            AddLog(string.Format("{0} : {1}", comment, dataText), logType);
        }

        void AddLog(string message, LogType logType)
        {
            Action addLog = () =>
            {
                #region addLog

                if (checkBoxShowSystemLog.Checked && logType == LogType.System) return;

                lock (listViewLog)
                {
                    listViewLog.BeginUpdate();
                    try
                    {
                        var item = listViewLog.Items.Add(message);
                        switch (logType)
                        {
                            case LogType.System: item.ForeColor = Color.Gray; break;
                            case LogType.Send: item.ForeColor = Color.Black; break;
                            case LogType.Received: item.ForeColor = Color.Blue; break;
                            default: throw new NotImplementedException();
                        }

                        if (checkBoxAutoScroll.Checked)
                        {
                            item.EnsureVisible();
                        }
                        listViewLog.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    }
                    finally
                    {
                        listViewLog.EndUpdate();
                    }
                }

                #endregion
            };

            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(addLog));
            }
            else
            {
                addLog();
            }
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateUI();
        }
    }
}
