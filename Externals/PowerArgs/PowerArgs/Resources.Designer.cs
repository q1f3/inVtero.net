﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PowerArgs {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PowerArgs.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;!DOCTYPE html&gt;
        ///&lt;html xmlns=&quot;http://www.w3.org/1999/xhtml&quot;&gt;
        ///&lt;head&gt;
        ///    &lt;title&gt;{{ExeName!}} documentation&lt;/title&gt;
        ///&lt;/head&gt;
        ///&lt;body&gt;
        ///    &lt;h1 class=&quot;program-specific-content&quot;&gt;{{ExeName!}}&lt;/h1&gt;
        ///    &lt;p class=&quot;program-specific-content&quot;&gt;{{Description!}}&lt;/p&gt;
        ///
        ///    &lt;h2&gt;Usage&lt;/h2&gt;
        ///&lt;pre class=&quot;code-sample&quot;&gt;{{UsageSummaryHTMLEncoded!}}&lt;/pre&gt;
        ///
        ///    {{if HasGlobalArguments}}
        ///    {{if HasActions}}&lt;h2&gt;Global options&lt;/h2&gt;!{{if}}
        ///    {{ifnot HasActions}}&lt;h2&gt;Options&lt;/h2&gt;!{{ifnot}}
        ///
        ///    &lt;table&gt;
        ///        &lt;tr&gt;
        ///            &lt;td class=&quot;o [rest of string was truncated]&quot;;.
        /// </summary>
        public static string DefaultBrowserUsageTemplate {
            get {
                return ResourceManager.GetString("DefaultBrowserUsageTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {{if HasDescription}}
        ///
        ///{{ Description !}}
        ///
        ///
        ///!{{if}}
        ///{{ifnot HasSpecifiedAction}}
        ///Usage - {{UsageSummary Cyan!}}
        ///!{{ifnot}}
        ///{{if HasGlobalArguments}}
        ///
        ///{{table Arguments Syntax&gt;GlobalOption Description !}}
        ///!{{if}}
        ///{{if HasActions}}
        ///{{if HasSpecifiedAction}}
        ///
        ///{{SpecifiedAction.DefaultAlias!}} - {{SpecifiedAction.Description!}}
        ///
        ///Usage - {{ExeName Cyan!}} {{SpecifiedAction.UsageSummary Cyan!}}
        ///
        ///{{if SpecifiedAction.HasArguments }}
        ///{{SpecifiedAction.DefaultAlias!}} Options
        ///{{table SpecifiedAction.Arguments Syntax [rest of string was truncated]&quot;;.
        /// </summary>
        public static string DefaultConsoleUsageTemplate {
            get {
                return ResourceManager.GetString("DefaultConsoleUsageTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Linq;
        ///using System.Collections.Generic;
        ///$Usings$
        ///
        ///namespace $Namespace$
        ///{
        ///    public class $Class$
        ///    {
        ///        public static List&lt;$ReturnType$&gt; $Method$(IEnumerable&lt;$ReturnType$&gt; source)
        ///        {
        ///            IEnumerable&lt;$ReturnType$&gt; query = from item in source select item;
        ///
        ///            $WhereComment$              query = from item in query where $Where$ select item;
        ///            $OrderByDescendingComment$  query = query.OrderByDescending($OrderByDescending$);
        ///            $Order [rest of string was truncated]&quot;;.
        /// </summary>
        public static string QueryTemplate {
            get {
                return ResourceManager.GetString("QueryTemplate", resourceCulture);
            }
        }
    }
}