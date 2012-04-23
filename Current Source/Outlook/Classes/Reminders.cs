using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice;
namespace NetOffice.OutlookApi
{

	#region Delegates

	#pragma warning disable
	public delegate void Reminders_BeforeReminderShowEventHandler(ref bool Cancel);
	public delegate void Reminders_ReminderAddEventHandler(NetOffice.OutlookApi._Reminder ReminderObject);
	public delegate void Reminders_ReminderChangeEventHandler(NetOffice.OutlookApi._Reminder ReminderObject);
	public delegate void Reminders_ReminderFireEventHandler(NetOffice.OutlookApi._Reminder ReminderObject);
	public delegate void Reminders_ReminderRemoveEventHandler();
	public delegate void Reminders_SnoozeEventHandler(NetOffice.OutlookApi._Reminder ReminderObject);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass Reminders 
	/// SupportByVersion Outlook, 10,11,12,14
	///</summary>
	[SupportByVersionAttribute("Outlook", 10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class Reminders : _Reminders,IEventBinding
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		ReminderCollectionEvents_SinkHelper _reminderCollectionEvents_SinkHelper;
	
		#endregion

		#region Type Information

        private static Type _type;
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(Reminders);
                    
                return _type;
            }
        }
        
        #endregion
        		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
		public Reminders(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
			
		}

		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Reminders(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
			
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Reminders(COMObject replacedObject) : base(replacedObject)
		{
			
		}
		
		/// <summary>
        /// creates a new instance of Reminders 
        /// </summary>		
		public Reminders():base("Outlook.Reminders")
		{
			
		}
		
		/// <summary>
        /// creates a new instance of Reminders
        /// </summary>
        /// <param name="progId">registered ProgID</param>
		public Reminders(string progId):base(progId)
		{
			
		}

		#endregion

		#region Events

		/// <summary>
		/// SupportByVersion Outlook, 10,11,12,14
		/// </summary>
		private event Reminders_BeforeReminderShowEventHandler _BeforeReminderShowEvent;

		/// <summary>
		/// SupportByVersion Outlook 10 11 12 14
		/// </summary>
		[SupportByVersion("Outlook", 10,11,12,14)]
		public event Reminders_BeforeReminderShowEventHandler BeforeReminderShowEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeReminderShowEvent += value;
			}
			remove
			{
				_BeforeReminderShowEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 10,11,12,14
		/// </summary>
		private event Reminders_ReminderAddEventHandler _ReminderAddEvent;

		/// <summary>
		/// SupportByVersion Outlook 10 11 12 14
		/// </summary>
		[SupportByVersion("Outlook", 10,11,12,14)]
		public event Reminders_ReminderAddEventHandler ReminderAddEvent
		{
			add
			{
				CreateEventBridge();
				_ReminderAddEvent += value;
			}
			remove
			{
				_ReminderAddEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 10,11,12,14
		/// </summary>
		private event Reminders_ReminderChangeEventHandler _ReminderChangeEvent;

		/// <summary>
		/// SupportByVersion Outlook 10 11 12 14
		/// </summary>
		[SupportByVersion("Outlook", 10,11,12,14)]
		public event Reminders_ReminderChangeEventHandler ReminderChangeEvent
		{
			add
			{
				CreateEventBridge();
				_ReminderChangeEvent += value;
			}
			remove
			{
				_ReminderChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 10,11,12,14
		/// </summary>
		private event Reminders_ReminderFireEventHandler _ReminderFireEvent;

		/// <summary>
		/// SupportByVersion Outlook 10 11 12 14
		/// </summary>
		[SupportByVersion("Outlook", 10,11,12,14)]
		public event Reminders_ReminderFireEventHandler ReminderFireEvent
		{
			add
			{
				CreateEventBridge();
				_ReminderFireEvent += value;
			}
			remove
			{
				_ReminderFireEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 10,11,12,14
		/// </summary>
		private event Reminders_ReminderRemoveEventHandler _ReminderRemoveEvent;

		/// <summary>
		/// SupportByVersion Outlook 10 11 12 14
		/// </summary>
		[SupportByVersion("Outlook", 10,11,12,14)]
		public event Reminders_ReminderRemoveEventHandler ReminderRemoveEvent
		{
			add
			{
				CreateEventBridge();
				_ReminderRemoveEvent += value;
			}
			remove
			{
				_ReminderRemoveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 10,11,12,14
		/// </summary>
		private event Reminders_SnoozeEventHandler _SnoozeEvent;

		/// <summary>
		/// SupportByVersion Outlook 10 11 12 14
		/// </summary>
		[SupportByVersion("Outlook", 10,11,12,14)]
		public event Reminders_SnoozeEventHandler SnoozeEvent
		{
			add
			{
				CreateEventBridge();
				_SnoozeEvent += value;
			}
			remove
			{
				_SnoozeEvent -= value;
			}
		}

		#endregion
       
	    #region IEventBinding Member
        
		/// <summary>
        /// creates active sink helper
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public void CreateEventBridge()
        {
			if(false == NetOffice.Settings.EnableEvents)
				return;
	
			if (null != _connectPoint)
				return;
	
            if (null == _activeSinkId)
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, ReminderCollectionEvents_SinkHelper.Id);


			if(ReminderCollectionEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_reminderCollectionEvents_SinkHelper = new ReminderCollectionEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool EventBridgeInitialized
        {
            get 
            {
                return (null != _connectPoint);
            }
        }
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients()       
        {
			if(null == _thisType)
				_thisType = this.GetType();
					
			foreach (NetRuntimeSystem.Reflection.EventInfo item in _thisType.GetEvents())
			{
				MulticastDelegate eventDelegate = (MulticastDelegate) _thisType.GetType().GetField(item.Name, 
																			NetRuntimeSystem.Reflection.BindingFlags.NonPublic |
																			NetRuntimeSystem.Reflection.BindingFlags.Instance).GetValue(this);
					
				if( (null != eventDelegate) && (eventDelegate.GetInvocationList().Length > 0) )
					return false;
			}
				
			return false;
        }
        
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public Delegate[] GetEventRecipients(string eventName)
        {
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                return delegates;
            }
            else
                return new Delegate[0];
        }

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public int GetCountOfEventRecipients(string eventName)
        {
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                return delegates.Length;
            }
            else
                return 0;
        }

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public int RaiseCustomEvent(string eventName, ref object[] paramsArray)
		{
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                foreach (var item in delegates)
                {
                    try
                    {
                        item.Method.Invoke(item.Target, paramsArray);
                    }
                    catch (NetRuntimeSystem.Exception exception)
                    {
                        DebugConsole.WriteException(exception);
                    }
                }
                return delegates.Length;
            }
            else
                return 0;
		}

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public void DisposeEventBridge()
        {
			if( null != _reminderCollectionEvents_SinkHelper)
			{
				_reminderCollectionEvents_SinkHelper.Dispose();
				_reminderCollectionEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion

		#pragma warning restore
	}
}