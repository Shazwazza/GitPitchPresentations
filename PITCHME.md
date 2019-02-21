---?color=#F2EBE6&image=template/img/umb/heart1.png&size=160px 160px&position=center



---?color=#3544B1
@title[Introduction]

## Building Packages with Umbraco 8

@snap[south span-100 text-07]
Shannon Deminick&nbsp;&nbsp;|&nbsp;&nbsp; @css[text-umb-pink](twitter): @shazwazza&nbsp;&nbsp;|&nbsp;&nbsp;@css[text-umb-pink](web): shazwazza.com
@snapend

Note:

* Introduce yourself

---?color=#3544B1
@title[Agenda]

## Upgrading&hellip;<br/>Building&hellip;<br/>Packaging&hellip;<br/>@css[text-umb-yellow](Learning!)

---?color=#F2EBE6

@title[Articulate]

@snap[west]
@img[split-screen-img span-80](template/img/umb/articulate.png)
@snapend

@snap[north-east text-20 text-bolder text-umb-blue]
Articulate
@snapend

@snap[east]
@ul[text-umb-dark-blue]
- Uses a __lot__ of Umbraco surface area
- A good way to test v8!
@olend
@snapend

---?color=#F2EBE6

@title[Surface Area]

@snap[west]
@img[split-screen-img span-80](template/img/umb/articulate.png)
@snapend

@snap[east]
@ul[text-umb-dark-blue]
- Custom routes & controllers
- Virtual nodes
- Content finders
- Event handlers
- Dashboards
- Property Editors
- Package manifest
- Lots of views
- Custom searching
- Custom DB queries
@olend
@snapend

---?color=#3544B1

@title[Upgrading]

@snap[midpoint span-100 text-15]
## Upgrading
@snapend

---?color=#3544B1

@snap[west span-45]
# MVC
@snapend

@snap[north-east span-60]
@box[bg-umb-grey text-umb-dark-blue rounded](Model# Quering published content and getting property values)
@snapend

@snap[east span-60]
@box[bg-umb-grey text-umb-dark-blue rounded](View# APIs available in Razor views)
@snapend

@snap[south-east span-60]
@box[bg-umb-grey text-umb-dark-blue rounded](Controller# Changes to controllers and how to create your own)
@snapend

---?color=#F2EBE6

@title[Published Content]

@snap[east text-17 text-bold text-umb-blue span-50]
Important changes
@snapend

@snap[west text-umb-dark-blue span-65]
@ul[split-screen-list text-08](false)
* One way to get property values
* No more dynamcis
* RenderModel doesn't exist, just IPublishedContent
@ulend
@snapend


---?color=#3544B1

@title[New Features]

@snap[midpoint span-100 text-15]
## New Features!
@snapend
@snap[midpoint span-100]
<br/>
<br/>
<br/>
@css[text-italic text-umb-pink text-08](...maybe some you haven't heard of!)
@snapend




---?color=#F2EBE6

@title[Custom Controllers]

@snap[west]
@img[split-screen-img span-80](template/img/umb/articulate.png)
@snapend

@snap[north-east text-20 text-bolder text-umb-blue]
Articulate
@snapend

@snap[east]
@ul[text-umb-dark-blue]
- Uses a lot of Umbraco surface area
- A good way to test v8!
@olend
@snapend