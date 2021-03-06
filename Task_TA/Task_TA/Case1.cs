///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace Task_TA
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Case1 recording.
    /// </summary>
    [TestModule("9fe4dcfe-0b07-4f10-a63c-2719b783ee17", ModuleType.Recording, 1)]
    public partial class Case1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Task_TARepository repository.
        /// </summary>
        public static Task_TARepository repo = Task_TARepository.Instance;

        static Case1 instance = new Case1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Case1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Case1 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.None12' at 4;8.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.None12Info, new RecordItemIndex(0));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.None12.Click("4;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.UEyeOl' at 117;14.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.UEyeOlInfo, new RecordItemIndex(1));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.UEyeOl.Click("117;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.UEyeOl' at -8;144.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.UEyeOlInfo, new RecordItemIndex(2));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.UEyeOl.Click("-8;144");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'e{NumPad1}{NumPad8}{NumPad0}{NumPad5}{NumPad0}{NumPad4}{NumPad0}{NumPad0}{NumPad8}{LControlKey down}{RMenu down}{Qkey}{LControlKey up}{LControlKey up}{RMenu up}stud.tau.edu.tr' with focus on 'EnTrendUEruenlerTuerkiyeninOnlineAl'.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.SelfInfo, new RecordItemIndex(3));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Self.EnsureVisible();
            Keyboard.Press("e{NumPad1}{NumPad8}{NumPad0}{NumPad5}{NumPad0}{NumPad4}{NumPad0}{NumPad0}{NumPad8}{LControlKey down}{RMenu down}{Qkey}{LControlKey up}{LControlKey up}{RMenu up}stud.tau.edu.tr");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.Text' at 139;18.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.TextInfo, new RecordItemIndex(4));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.Text.Click("139;18");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'deneme{NumPad1}{NumPad2}.' with focus on 'EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.Text'.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.TextInfo, new RecordItemIndex(5));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.Text.PressKeys("deneme{NumPad1}{NumPad2}.");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.None1' at 12;7.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.None1Info, new RecordItemIndex(6));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.None1.Click("12;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.EPosta'.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.EPostaInfo, new RecordItemIndex(7));
            Validate.Exists(repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.EPostaInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='e180504008@stud.tau.edu.tr') on item 'EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.ComboBox'.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.ComboBoxInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.ComboBoxInfo, "Text", "e180504008@stud.tau.edu.tr");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.Şifre'.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.ŞifreInfo, new RecordItemIndex(9));
            Validate.Exists(repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.ŞifreInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.Text'.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.TextInfo, new RecordItemIndex(10));
            Validate.Exists(repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.TextInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.None1'.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.None1Info, new RecordItemIndex(11));
            Validate.Exists(repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.None1Info);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
