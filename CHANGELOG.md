# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [1.1.2] - 2023-08-10

### Fixed

-   Fixed a build error on Linux caused by Nintendo Switch Pro controller not being supported on Linux, for some reason.

## [1.1.1] - 2023-08-06


### Fixed

-   Removed a redundant testing `Debug.Log`.

## [1.1.0] - 2023-08-06

### Changed

-   `InputUtilities` is now based on the new input system and works better with *Steam* integrations.

## [1.0.8] - 2022-11-09

### Fixed

-   Fixed an error with the `InputUtilities.IsUsingController()` method, where it would throw an error if there are no active controllers.

## [1.0.7] - 2022-08-06

### Fixed

-   Fixed a build error caused by `GizmoUtilities` being in the Editor Scripts.

### Added

-   Added new methods to `GizmoUtilities` for drawing crosses.
-   Added a 3D arrow drawing method to `GizmoUtilities`.

### Changed

-   `GizmoUtilities.DrawArrow2D` now uses the new `GizmoUtilities.DrawArrow` method for drawing arrows.
-   Made the utility classes static.

## [1.0.6] - 2022-07-29

### Added

-   Added `GizmoUtilities` class for helping with complex Gizmos drawings. Currently it only has one method, which is for drawing an arrow in 2D.

## [1.0.5] - 2022-02-08

### Fixed

-   Fixed the error `Asset Packages/com.dartcore.utilities/CHANGELOG.md has no meta file, but it's in an immutable folder. The asset will be ignored.`

## [1.0.4] - 2022-01-11

### Added

-   Added `MathUtilities.GetRandomItem()` method to choose a random item from the given array or list.
