﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FindANameFarm.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FindANameFarm.Properties.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Task Finish Date can&apos;t be before task start date.
        /// </summary>
        internal static string CheckDates {
            get {
                return ResourceManager.GetString("CheckDates", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap defaultImage {
            get {
                object obj = ResourceManager.GetObject("defaultImage", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Something went wrong please try again later.
        /// </summary>
        internal static string Error {
            get {
                return ResourceManager.GetString("Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you want to exit the application?.
        /// </summary>
        internal static string Exit_message {
            get {
                return ResourceManager.GetString("Exit message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are You Sure.
        /// </summary>
        internal static string Exit_Title {
            get {
                return ResourceManager.GetString("Exit Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter both your employee number and your password.
        /// </summary>
        internal static string Login_btnLogin_Click_Please_enter_both_your_employee_number_and_your_password {
            get {
                return ResourceManager.GetString("Login_btnLogin_Click_Please_enter_both_your_employee_number_and_your_password", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your employee number and password don&apos;t match, please try again.
        /// </summary>
        internal static string Login_btnLogin_Click_Your_employee_number_and_password_don_t_match__please_try_again {
            get {
                return ResourceManager.GetString("Login_btnLogin_Click_Your_employee_number_and_password_don_t_match__please_try_ag" +
                        "ain", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap login_image {
            get {
                object obj = ResourceManager.GetObject("login image", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please Select A Staff member to remove first.
        /// </summary>
        internal static string SelectStaffMemberFirst {
            get {
                return ResourceManager.GetString("SelectStaffMemberFirst", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You dont have any vehicles in that category.
        /// </summary>
        internal static string SelectVehicleCat {
            get {
                return ResourceManager.GetString("SelectVehicleCat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please Select A vehicle to remove first.
        /// </summary>
        internal static string SelectVehicleFirst {
            get {
                return ResourceManager.GetString("SelectVehicleFirst", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please Select a member of staff to remove.
        /// </summary>
        internal static string SowingTaskForm_btnRemoveLabourerFromTask_Click_Please_Select_a_member_of_staff_to_remove {
            get {
                return ResourceManager.GetString("SowingTaskForm_btnRemoveLabourerFromTask_Click_Please_Select_a_member_of_staff_to" +
                        "_remove", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Staff Member Already on task.
        /// </summary>
        internal static string StaffMemberExists {
            get {
                return ResourceManager.GetString("StaffMemberExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Staff Member or vehicle Already on task.
        /// </summary>
        internal static string StaffOrVehicleExist {
            get {
                return ResourceManager.GetString("StaffOrVehicleExist", resourceCulture);
            }
        }
    }
}
