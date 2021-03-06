# Release Notes

##### 1.1.2.1
- Fixed a bug in Android causing `MaterialButtonRenderer` throwing a `System.NullReferenceException` when `MaterialButton` `Image` property is set. A bug reported in this [issue](https://github.com/contrix09/XF-Material-Library/issues/21).

##### 1.1.2
- Reworked `MaterialRadioButtonGroup`. Once a choice has been selected, you can no longer unselect a choice. A bug reported in this [issue](https://github.com/contrix09/XF-Material-Library/issues/11).
- Changed the minimum and target `MonoAndroid` framework version to `8.1`. Fixed also some inconsistencies in the referenced NuGet packages of the library. A bug reported in this [issue](https://github.com/contrix09/XF-Material-Library/issues/13).
- Removed the `font` directory in the `Resources` folder in `XF.Material.Droid`.
- Fixed a bug when calling `XF.Material.Forms.Material.Init(Application app)` causing `System.NullException`. A bug reported in this [issue](https://github.com/contrix09/XF-Material-Library/issues/14).
- Fixed a bug when canceling a confirmation dialog shown using `MaterialDialog.Instance.SelectChoicesAsync()` not clearing the currently selected choices.
- Fixed a bug in `MaterialRadioButtonGroup` and `MaterialCheckboxGroup` not updating `SelectedIndex` and `SelectedIndices` property, respectively.

##### 1.1.1
- Added parameters `selectedIndex` and `selectedIndices` to `IMaterialDialog.SelectChoiceAsync` and `IMaterialDialog.SelectChoicesAsync`. A feature enhancement as stated in this [issue](https://github.com/contrix09/XF-Material-Library/issues/9).
- Fixed `MaterialRadioButtonGroup` and `MaterialCheckboxGroup` having an extra empty row.
- Fixed `MaterialButtonRenderer` in iOS not responding to changes in `MaterialButton.AllCaps` property.

##### 1.1.0
- Added selection controls: `MaterialRadioButton`, `MaterialRadioButtonGroup`, `MaterialCheckbox`, and `MaterialCheckboxGroup`.
- Deprecated `MaterialDialogs`, you should use `MaterialDialog.Instance` for displaying modal dialogs.
- Added simple dialog and confirmation dialog to `MaterialDialog`.
- Added `ReturnType`, `ReturnTypeCommand`, and `ReturnTypeCommandParameter` properties to `MaterialTextField`. A feature enhancement stated in this [issue](https://github.com/contrix09/XF-Material-Library/issues/5).
- Changed the default color values of `MaterialColorConfiguration`.
- Fixed a bug in Android when using `MaterialIcon`, which causes all other views using the same resource image to change color when one of them was changed.
- Fixed a bug in Android when using `MaterialButton`, which causes text button type not having a disabled text state.
- Removed the back button title in iOS when using `MaterialNavigationPage`.
- Removed `ColorConfiguration` and `FontConfiguration` in `XF.Material.Forms.Material` class. Added static subclasses `Color` and `FontFamily` with static properties that will hold the values of the current color and font configurations.

##### 1.0.6
- Refactored `MaterialDialogs`. A feature enhancement stated in this [issue](https://github.com/contrix09/XF-Material-Library/issues/4).
  - Added `MaterialDialogs.ShowConfirmAsync()`. Use this for user confirmation of action. Returns a `boolean` value based on what the user chose.
  - `MaterialDialogs.ShowAlertAsync` is now only used for user acknowledgement purposes.
  - The overload method of `MaterialDialogs.ShowSnackbarAsync()` that has an action now also returns a `boolean` value.
- Changed the minimum `Xamarin.Android.Support.*` verion to `25.4.0.2` to address this [issue](https://github.com/contrix09/XF-Material-Library/issues/3). This is the same minimum version that the latest `Xamarin.Forms` Nuget package accepts. 
- Changed the assembly and namespace name from `XF.Material` to `XF.Material.Forms`.
- Added static properties `ColorConfiguration` and `FontConfiguration` to `XF.Material.Forms.Material` class.

##### 1.0.5
- Added NuGet Package icon.
- Added `MaterialAlertDialogConfiguration`, `MaterialLoadingConfiguration`, and `MaterialSnackbarConfiguration` for
styling modals created by `MaterialDialogs`.
- Added `MaterialConstants`, a static class to provide constant key values of Material Resources.
- Refactored methods in `MaterialDialogs`.
- Fixed `MaterialButton` throwing exception on devices running Android 4.2.
- Fixed `MaterialTextField` not showing error icon on iOS when the property `HasError` is set to `true`.

##### 1.0.4
- Fixed NuGet Package not including the features from version `1.0.3`.
- Updated to the latest Xamarin.Forms.

##### 1.0.3
- Added `MaterialTextField` and `MaterialIcon`.

##### 1.0.2
- Added type scale fonts in `MaterialFontConfiguration`.

##### 1.0.1
- Fixed some rendering bugs.
- Added a `FontAttribute.Bold` `DynamicResource` value to `MaterialButton`.
- Removed `Padding` values in `MaterialChip`.
- Pages pushed in `MaterialNavigationPage` will have a default `BackgroundColor` value equal to the `MaterialColorConfiguration.Background`, unless the `BackgroundColor` property is set in the page.

##### 1.0.0
- Initial release.