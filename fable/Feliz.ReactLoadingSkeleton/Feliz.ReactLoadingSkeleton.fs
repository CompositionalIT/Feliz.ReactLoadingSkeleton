module Feliz.ReactLoadingSkeleton

open Feliz
open Fable.Core.JsInterop

let skeleton: obj = importDefault "react-loading-skeleton"
let skeletonTheme: obj = import "SkeletonTheme" "react-loading-skeleton"

type ISkeletonThemeProperty = interface end

type SkeletonTheme =
    static member inline color (color: string) = unbox<ISkeletonThemeProperty>("color" ==> color)
    static member inline highlightColor (color: string) = unbox<ISkeletonThemeProperty>("highlightColor" ==> color)

    static member inline children (elements: ReactElement list) = unbox<ISkeletonThemeProperty>(prop.children elements)

    static member inline skeletonTheme (props: ISkeletonThemeProperty list) =
        Interop.reactApi.createElement (skeletonTheme, createObj !!props)

type ISkeletonProperty = interface end

type Skeleton =

    static member inline count (number: int) = unbox<ISkeletonProperty> ("count" ==> number)
    static member inline duration (number: int) = unbox<ISkeletonProperty> ("duration" ==> number)
    static member inline delay (number: int) = unbox<ISkeletonProperty> ("delay" ==> number)
    static member inline width (number: int) = unbox<ISkeletonProperty> ("width" ==> number)
    static member inline height (number: int) = unbox<ISkeletonProperty> ("height" ==> number)

    static member inline circle (bool: bool) = unbox<ISkeletonProperty> ("circle" ==> bool)

    static member inline skeleton (props: ISkeletonProperty list) =
        Interop.reactApi.createElement (skeleton, createObj !!props)

