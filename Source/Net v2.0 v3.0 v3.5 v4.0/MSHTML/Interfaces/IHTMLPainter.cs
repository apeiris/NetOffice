//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.MSHTMLApi
{
	///<summary>
	/// Interface IHTMLPainter SupportByLibraryAttribute MSHTML, 4
	///</summary>
	[SupportByLibraryAttribute("MSHTML", 4)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class IHTMLPainter : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(IHTMLPainter);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLPainter(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLPainter(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLPainter(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLPainter() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLPainter(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="rcBounds">tagRECT rcBounds</param>
		/// <param name="rcUpdate">tagRECT rcUpdate</param>
		/// <param name="lDrawFlags">Int32 lDrawFlags</param>
		/// <param name="hdc">_RemotableHandle hdc</param>
		/// <param name="pvDrawObject">object pvDrawObject</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 Draw(tagRECT rcBounds, tagRECT rcUpdate, Int32 lDrawFlags, _RemotableHandle hdc, object pvDrawObject)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(rcBounds, rcUpdate, lDrawFlags, hdc, pvDrawObject);
			object returnItem = Invoker.MethodReturn(this, "Draw", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="size">tagSIZE size</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 onresize(tagSIZE size)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(size);
			object returnItem = Invoker.MethodReturn(this, "onresize", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pInfo">_HTML_PAINTER_INFO pInfo</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 GetPainterInfo(_HTML_PAINTER_INFO pInfo)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pInfo);
			object returnItem = Invoker.MethodReturn(this, "GetPainterInfo", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pt">tagPOINT pt</param>
		/// <param name="pbHit">Int32 pbHit</param>
		/// <param name="plPartID">Int32 plPartID</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 HitTestPoint(tagPOINT pt, Int32 pbHit, Int32 plPartID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pt, pbHit, plPartID);
			object returnItem = Invoker.MethodReturn(this, "HitTestPoint", paramsArray);
			return (Int32)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}