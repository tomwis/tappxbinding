# Xamarin Android Binding for Tappx SDK

This repository contains Java Library binding for Tappx SDK.
* Tappx SDK version in the binding: 3.0.5

Useful links:
* Tappx website: http://www.tappx.com/en/
* Android integration guide: http://www.tappx.com/en/manual/?os=and#1_integration

## How to use
1. Download code and build.
2. Get TappxBinding.dll from TappxBinding/bin/Release and add it as reference to you Xamarin.Android project.
3. Create banner or interstitial ad in your project.
4. Create account on Tappx website, create new app here and copy the key to your app.

There is a sample project (TappxBinding.Example) showing how to create banner ad from xml or code. If you want to build it to see the result you will have to replace value with name "tappx_key" in Resources/values/Strings.xml to your own key (created in step 4 above).

<img src="/screenshot.png" width="300">
