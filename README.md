# 🎨 Démonstration WPF : Styles, Templates et UserControls

## 📋 Description

Cette application de démonstration illustre les concepts fondamentaux de personnalisation des interfaces utilisateur en WPF (Windows Presentation Foundation). Elle montre comment transformer complètement l'apparence et le comportement des contrôles de base tout en conservant leur fonctionnalité native.

## 🎯 Objectifs pédagogiques

Ce projet démontre concrètement que **WPF permet de personnaliser n'importe quel contrôle** grâce à trois mécanismes principaux :

- **🎨 Styles** : Modification de l'apparence sans changer la structure
- **🔧 Control Templates** : Redéfinition complète de la structure visuelle
- **📦 User Controls** : Création de contrôles composites réutilisables

## ✨ Fonctionnalités démontrées

### 1. **Styles WPF**
- Style simple avec modification des couleurs et du padding
- Style avancé avec animations et effets de survol
- TextBox personnalisé avec style moderne

### 2. **Control Templates**
- Transformation de boutons rectangulaires en boutons circulaires
- Gestion des états visuels (Normal, Hover, Pressed)
- Triggers pour les interactions utilisateur

### 3. **User Controls**
- Contrôle personnalisé réutilisable (`CustomCard`)
- Dependency Properties pour la personnalisation
- Gestion d'événements personnalisés

## 🛠 Prérequis

- **Visual Studio 2019/2022** ou **VS Code** avec l'extension C#
- **.NET 6.0** ou version ultérieure
- **SDK Windows** (inclus avec Visual Studio)

## 📁 Structure du projet

```
WpfDemoApp/
├── MainWindow.xaml              # Fenêtre principale avec les démonstrations
├── MainWindow.xaml.cs           # Code-behind avec logique d'interaction
├── CustomCard.xaml              # UserControl personnalisé
├── CustomCard.xaml.cs           # Dependency Properties et événements
├── App.xaml                     # Configuration de l'application
├── App.xaml.cs                  # Point d'entrée de l'application
└── WpfDemoApp.csproj           # Configuration du projet .NET
```

## 🎨 Aperçu visuel

### Section 1 : Styles
- **Bouton par défaut** : Apparence Windows standard
- **Style simple** : Bouton vert avec texte blanc
- **Style animé** : Bouton bleu avec effet de zoom au survol

### Section 2 : Control Templates  
- **Boutons circulaires** : Play ▶, Pause ⏸, Stop ⏹
- **Effets visuels** : Animation de couleur et effet de pression
- **Feedback utilisateur** : Texte dynamique selon l'action

### Section 3 : Contrôles personnalisés
- **TextBox standard** vs **TextBox moderne** (sans bordures, avec ligne de focus)
- **CheckBox** avec styles personnalisés

### Section 4 : User Controls
- **Cartes d'information** réutilisables
- **Personnalisation** : Titre, description, icône, couleur
- **Interactivité** : Bouton d'action avec événement personnalisé

## 🔑 Concepts techniques abordés

### **Styles**
```xml
<Style x:Key="AnimatedButtonStyle" TargetType="Button">
    <Setter Property="Background" Value="#2196F3"/>
    <Style.Triggers>
        <Trigger Property="IsMouseOver" Value="True">
            <Setter Property="RenderTransform">
                <Setter.Value>
                    <ScaleTransform ScaleX="1.05" ScaleY="1.05"/>
                </Setter.Value>
            </Setter>
        </Trigger>
    </Style.Triggers>
</Style>
```

### **Control Templates**
```xml
<Style x:Key="CircularButtonStyle" TargetType="Button">
    <Setter Property="Template">
        <Setter.Value>
            <ControlTemplate TargetType="Button">
                <Ellipse Fill="#FF9800" Stroke="#F57C00"/>
                <ContentPresenter HorizontalAlignment="Center"/>
            </ControlTemplate>
        </Setter.Value>
    </Setter>
</Style>
```

### **Dependency Properties**
```csharp
public static readonly DependencyProperty TitleProperty =
    DependencyProperty.Register("Title", typeof(string), typeof(CustomCard), 
        new PropertyMetadata("Titre par défaut"));

public string Title
{
    get { return (string)GetValue(TitleProperty); }
    set { SetValue(TitleProperty, value); }
}
```

## 💡 Points clés à retenir

1. **Séparation des responsabilités** : L'apparence est découplée de la logique métier
2. **Réutilisabilité** : Un style/template peut être appliqué à plusieurs contrôles
3. **Maintenabilité** : Modification centralisée de l'apparence
4. **Flexibilité** : Personnalisation complète sans perdre la fonctionnalité native
5. **Performance** : Les templates sont compilés et optimisés par WPF
