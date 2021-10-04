using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Com.Github.Javiersantos.Appupdater;
using Com.Github.Javiersantos.Appupdater.Enums;

namespace App1.Droid
{
    [Activity(Label = "App1", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
            /* this.RunOnUiThread(new Java.Lang.Runnable(() =>
             {
                 var a = new AppUpdater(this);
                 a.Start();
             }));*/

            /*((Activity)this).RunOnUiThread(new Java.Lang.Runnable()
                {
                        public void run()
                {
                    Toast.makeText(AddRecord.this, "" + e.toString(), Toast.LENGTH_SHORT).show();
                }
            });*/
            var a  = this.ApplicationInfo.LabelRes;
            var b  = a == 0 ? this.ApplicationInfo.NonLocalizedLabel.ToString() : this.GetString(a);
            new AppUpdater(this)
                        //.setUpdateFrom(UpdateFrom.GITHUB)
                        //.setGitHubUserAndRepo("javiersantos", "AppUpdater")
                        .SetUpdateFrom(UpdateFrom.Json)
                        //.SetUpdateJSON("https://raw.githubusercontent.com/javiersantos/AppUpdater/master/app/update-changelog.json")
                        .SetUpdateJSON("https://raw.githubusercontent.com/javiersantos/AppUpdater/master/app/update.json")
                        .SetDisplay(Com.Github.Javiersantos.Appupdater.Enums.Display.Dialog)
                        .ShowAppUpdated((Java.Lang.Boolean)true)
                        .Start();
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}