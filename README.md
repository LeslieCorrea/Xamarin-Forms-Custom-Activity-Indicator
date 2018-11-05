# Xamarin-Forms-Custom-Activity-Indicator
Xamarin Forms Custom Activity Indicator using GIF image.

## Description
This can be used to show custom activity indicator by using GIF images, since in Xamarin forms it is not possible to show GIF images directly web-view is used. For android image must be placed inside assets folder and Build Action must be set to AndroidAsset. For iOS image must be placed inside resources and Build Action must be BundleResource. AbsoluteLayout is used for placing the image to center, IsBusy property is used for controlling the visibility of the activity indicator. [Dependency service](https://developer.xamarin.com/guides/xamarin-forms/application-fundamentals/dependency-service/introduction/) is used for getting the image path. [MVVM Helpers](https://github.com/jamesmontemagno/mvvm-helpers) is used basic properties. The Activity Indicator code is written in common folder so that it can be reused at many places. CommonFunctions is used for generic methods.

## Authors

* **Leslie Correa** - *Contributor* - [LeslieCorrea](https://github.com/LeslieCorrea)


## License

This project is licensed under the MIT License - see the [LICENSE.md](https://github.com/LeslieCorrea/Xamarin-Forms-Custom-Activity-Indicator/blob/master/LICENSE) file for details.
