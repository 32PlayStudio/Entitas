﻿//HintName: MyApp.ContextInitialization.Initialize.ContextInitialization.g.cs
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by
//     Entitas.Generators.ComponentGenerator.ContextInitializationMethod
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using global::MyApp.Main;

namespace MyApp
{
public static partial class ContextInitialization
{
    public static partial void Initialize()
    {
        global::MyAppMainMultipleFieldsComponentIndex.Index = new ComponentIndex(0);
        global::MyFeature.MyAppMainAnotherNamespacedComponentIndex.Index = new ComponentIndex(1);
        global::MyFeature.MyAppMainDuplicatedContextsNamespacedComponentIndex.Index = new ComponentIndex(2);
        global::MyFeature.MyAppMainEventNamespacedComponentIndex.Index = new ComponentIndex(3);
        global::MyFeature.MyAppMainFlagEventNamespacedComponentIndex.Index = new ComponentIndex(4);
        global::MyFeature.MyAppMainMultipleFieldsNamespacedComponentIndex.Index = new ComponentIndex(5);
        global::MyFeature.MyAppMainMultiplePropertiesNamespacedComponentIndex.Index = new ComponentIndex(6);
        global::MyFeature.MyAppMainAnyEventNamespacedAddedListenerComponentIndex.Index = new ComponentIndex(7);
        global::MyFeature.MyAppMainAnyEventNamespacedRemovedListenerComponentIndex.Index = new ComponentIndex(8);
        global::MyFeature.MyAppMainAnyFlagEventNamespacedAddedListenerComponentIndex.Index = new ComponentIndex(9);
        global::MyFeature.MyAppMainAnyFlagEventNamespacedRemovedListenerComponentIndex.Index = new ComponentIndex(10);
        global::MyFeature.MyAppMainEventNamespacedAddedListenerComponentIndex.Index = new ComponentIndex(11);
        global::MyFeature.MyAppMainEventNamespacedRemovedListenerComponentIndex.Index = new ComponentIndex(12);
        global::MyFeature.MyAppMainFlagEventNamespacedAddedListenerComponentIndex.Index = new ComponentIndex(13);
        global::MyFeature.MyAppMainFlagEventNamespacedRemovedListenerComponentIndex.Index = new ComponentIndex(14);
        global::MyFeature.MyAppMainNonPublicComponentIndex.Index = new ComponentIndex(15);
        global::MyFeature.MyAppMainNoValidFieldsNamespacedComponentIndex.Index = new ComponentIndex(16);
        global::MyFeature.MyAppMainOneFieldNamespacedComponentIndex.Index = new ComponentIndex(17);
        global::MyFeature.MyAppMainReservedKeywordFieldsNamespacedComponentIndex.Index = new ComponentIndex(18);
        global::MyFeature.MyAppMainSomeNamespacedComponentIndex.Index = new ComponentIndex(19);
        global::MyFeature.MyAppMainSomeNamespacedComponentIndex.Index = new ComponentIndex(20);
        global::MyFeature.MyAppMainUniqueNamespacedComponentIndex.Index = new ComponentIndex(21);
        global::MyFeature.MyAppMainUniqueOneFieldNamespacedComponentIndex.Index = new ComponentIndex(22);
        global::MyAppMainOneFieldComponentIndex.Index = new ComponentIndex(23);
        global::MyAppMainSomeComponentIndex.Index = new ComponentIndex(24);

        MyApp.MainContext.ComponentNames = new string[]
        {
            "MultipleFields",
            "MyFeature.AnotherNamespaced",
            "MyFeature.DuplicatedContextsNamespaced",
            "MyFeature.EventNamespaced",
            "MyFeature.FlagEventNamespaced",
            "MyFeature.MultipleFieldsNamespaced",
            "MyFeature.MultiplePropertiesNamespaced",
            "MyFeature.MyAppMainAnyEventNamespacedAddedListener",
            "MyFeature.MyAppMainAnyEventNamespacedRemovedListener",
            "MyFeature.MyAppMainAnyFlagEventNamespacedAddedListener",
            "MyFeature.MyAppMainAnyFlagEventNamespacedRemovedListener",
            "MyFeature.MyAppMainEventNamespacedAddedListener",
            "MyFeature.MyAppMainEventNamespacedRemovedListener",
            "MyFeature.MyAppMainFlagEventNamespacedAddedListener",
            "MyFeature.MyAppMainFlagEventNamespacedRemovedListener",
            "MyFeature.NonPublic",
            "MyFeature.NoValidFieldsNamespaced",
            "MyFeature.OneFieldNamespaced",
            "MyFeature.ReservedKeywordFieldsNamespaced",
            "MyFeature.SomeNamespaced",
            "MyFeature.SomeNamespaced",
            "MyFeature.UniqueNamespaced",
            "MyFeature.UniqueOneFieldNamespaced",
            "OneField",
            "Some"
        };

        MyApp.MainContext.ComponentTypes = new global::System.Type[]
        {
            typeof(global::MultipleFieldsComponent),
            typeof(global::MyFeature.AnotherNamespacedComponent),
            typeof(global::MyFeature.DuplicatedContextsNamespacedComponent),
            typeof(global::MyFeature.EventNamespacedComponent),
            typeof(global::MyFeature.FlagEventNamespacedComponent),
            typeof(global::MyFeature.MultipleFieldsNamespacedComponent),
            typeof(global::MyFeature.MultiplePropertiesNamespacedComponent),
            typeof(global::MyFeature.MyAppMainAnyEventNamespacedAddedListenerComponent),
            typeof(global::MyFeature.MyAppMainAnyEventNamespacedRemovedListenerComponent),
            typeof(global::MyFeature.MyAppMainAnyFlagEventNamespacedAddedListenerComponent),
            typeof(global::MyFeature.MyAppMainAnyFlagEventNamespacedRemovedListenerComponent),
            typeof(global::MyFeature.MyAppMainEventNamespacedAddedListenerComponent),
            typeof(global::MyFeature.MyAppMainEventNamespacedRemovedListenerComponent),
            typeof(global::MyFeature.MyAppMainFlagEventNamespacedAddedListenerComponent),
            typeof(global::MyFeature.MyAppMainFlagEventNamespacedRemovedListenerComponent),
            typeof(global::MyFeature.NonPublicComponent),
            typeof(global::MyFeature.NoValidFieldsNamespacedComponent),
            typeof(global::MyFeature.OneFieldNamespacedComponent),
            typeof(global::MyFeature.ReservedKeywordFieldsNamespacedComponent),
            typeof(global::MyFeature.SomeNamespacedComponent),
            typeof(global::MyFeature.SomeNamespacedComponent),
            typeof(global::MyFeature.UniqueNamespacedComponent),
            typeof(global::MyFeature.UniqueOneFieldNamespacedComponent),
            typeof(global::OneFieldComponent),
            typeof(global::SomeComponent)
        };
    }
}
}
