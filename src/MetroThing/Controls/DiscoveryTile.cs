using System;
using System.Collections.Specialized;
using System.Linq;
using MetroFramework;
using MetroFramework.Controls;
using SyncthingCore;

namespace MetroThing.Controls
{
    public partial class DiscoveryTile : MetroUserControl
    {
        private ManagedInstance _instance;

        public DiscoveryTile()
        {
            InitializeComponent();
        }

        public ManagedInstance Instance
        {
            get { return _instance; }
            set
            {
                // Clear old event listeners
                if (_instance != null)
                {
                    _instance.Announcers.CollectionChanged -= OnCollectionChanged;
                    _instance.Disconnected -= OnDisconnected;
                }


                // Attach new event listeners
                if (value != null)
                {
                    value.Announcers.CollectionChanged += OnCollectionChanged;
                    value.Disconnected += OnDisconnected;
                }


                _instance = value;
            }
        }

        private void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                case NotifyCollectionChangedAction.Remove:
                case NotifyCollectionChangedAction.Reset:
                    // Collect online and offline numbers
                    var connectedAnnouncers =
                        (from announcer in Instance.Announcers where announcer.Connected select announcer)
                            .ToList();

                    var disconnectedAnnouncers =
                        (from announcer in Instance.Announcers where !announcer.Connected select announcer)
                            .ToList();

                    // Set label
                    discoLabel.Text = string.Format("{0}/{1}", connectedAnnouncers.Count, Instance.Announcers.Count);

                    // Set style
                    if (connectedAnnouncers.Count > 0 && connectedAnnouncers.Count == Instance.Announcers.Count)
                    {
                        discoTile.Style = MetroColorStyle.Lime;
                    }
                    else if (connectedAnnouncers.Count > 0)
                    {
                        discoTile.Style = MetroColorStyle.Orange;
                    }
                    else
                    {
                        discoTile.Style = MetroColorStyle.Red;
                    }

                    discoTile.Refresh();

                    // Set tooltip
                    if (disconnectedAnnouncers.Count == 0)
                    {
                        Tooltip.SetToolTip(discoTile, "Connected to all announcers");
                    }
                    else
                    {
                        var errorMessage = "Could not connect to:" + Environment.NewLine;

                        errorMessage = disconnectedAnnouncers.Aggregate(errorMessage,
                            (current, announcer) => current + (announcer + Environment.NewLine));

                        Tooltip.SetToolTip(discoTile, errorMessage);
                    }
                    break;
            }
        }

        private void OnDisconnected(object sender, InstanceEventArgs e)
        {
            discoLabel.Text = String.Empty;
            discoTile.Style = MetroColorStyle.Orange;
            discoTile.Refresh();
            Tooltip.RemoveAll();
        }
    }
}