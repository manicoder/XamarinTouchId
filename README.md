# XamarinTouchId
1. Add Plugin.Fingerprint nougat package
2. Add Plugin.CurrentActivity (Andoid only) 
add this line in Main Activity to handle touch id with current activity (CrossFingerprint.SetCurrentActivityResolver(() => CrossCurrentActivity.Current.Activity))
