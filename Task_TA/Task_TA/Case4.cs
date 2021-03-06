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
    ///The Case4 recording.
    /// </summary>
    [TestModule("4c7aa781-e7b8-4997-beb2-3b7eb4a638c5", ModuleType.Recording, 1)]
    public partial class Case4 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Task_TARepository repository.
        /// </summary>
        public static Task_TARepository repo = Task_TARepository.Instance;

        static Case4 instance = new Case4();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Case4()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Case4 Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.GirişYap' at 47;15.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.GirişYapInfo, new RecordItemIndex(0));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.GirişYap.Click("47;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.ComboBox' at 137;30.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.ComboBoxInfo, new RecordItemIndex(1));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.ComboBox.Click("137;30");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'testotomasyon{NumPad2}{NumPad2}{RMenu down}{LControlKey down}{Qkey}{LControlKey up}{LControlKey up}{RMenu up}gmail.com' with focus on 'EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.ComboBox'.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.ComboBoxInfo, new RecordItemIndex(2));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.ComboBox.PressKeys("testotomasyon{NumPad2}{NumPad2}{RMenu down}{LControlKey down}{Qkey}{LControlKey up}{LControlKey up}{RMenu up}gmail.com");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.Text' at 85;16.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.TextInfo, new RecordItemIndex(3));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.Text.Click("85;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'deneme{NumPad1}{NumPad2}.' with focus on 'EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.Text'.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.TextInfo, new RecordItemIndex(4));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.Text.PressKeys("deneme{NumPad1}{NumPad2}.");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.GİRİŞYAP' at 72;22.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.GİRİŞYAPInfo, new RecordItemIndex(5));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.GİRİŞYAP.Click("72;22");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.AradığınızUeruenKategoriVeyaMarkayı' at 219;17.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.AradığınızUeruenKategoriVeyaMarkayıInfo, new RecordItemIndex(6));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.AradığınızUeruenKategoriVeyaMarkayı.Click("219;17");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'kulaklık' with focus on 'EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.AradığınızUeruenKategoriVeyaMarkayı'.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.AradığınızUeruenKategoriVeyaMarkayıInfo, new RecordItemIndex(7));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.AradığınızUeruenKategoriVeyaMarkayı.PressKeys("kulaklık");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.None6' at 2;9.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.None6Info, new RecordItemIndex(8));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.None6.Click("2;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.None7' at 135;3.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.None7Info, new RecordItemIndex(9));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.None7.Click("135;3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.SepeteEkle' at 21;7.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.SepeteEkleInfo, new RecordItemIndex(10));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.SepeteEkle.Click("21;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.LinkSepetim2' at 43;30.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.LinkSepetim2Info, new RecordItemIndex(11));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.LinkSepetim2.Click("43;30");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.Sepetim2UEruen'.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.Sepetim2UEruenInfo, new RecordItemIndex(12));
            Validate.Exists(repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Grouping.Sepetim2UEruenInfo);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
