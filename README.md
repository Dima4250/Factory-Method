Понятие паттернов проектирования:

Паттерны — это типовые решения распространённых проблем в проектировании ПО. Они помогают создавать гибкий, поддерживаемый и масштабируемый код.

Паттерны проектирования делятся на следующие категории:

1. Архитектурные - определяют общую структуру системы, разделяя её на подсистемы и описывая их взаимодействие.

2. Порождающие - шаблоны проектирования, которые абстрагируют процесс создания объектов. Они позволяют сделать систему независимой от способа создания, композиции и представления объектов.

3. Структурные - шаблоны проектирования, в которых рассматривается вопрос о том, как из классов и объектов образуются более крупные структуры.

4. Поведенческие - шаблоны проектирования, определяющие алгоритмы и способы реализации взаимодействия различных объектов и классов.

5. Идиомы - низкоуровневые решения типовых задач реализации, например очистка мусора - Disposable().

Паттерн Factory Method (Фабричный метод)
Тип: Порождающий паттерн
Назначение: Определяет интерфейс для создания объекта, но оставляет подклассам решение о том, какой класс инстанцировать. Позволяет делегировать создание объектов подклассам.

Описание:
- Product - интерфейс создаваемых объектов
- ConcreteProduct - конкретные реализации
- Creator - базовый класс с фабричным методом
- ConcreteCreator - переопределяет фабричный метод
- 
Паттерн Factory Method решает проблемы:
- Жесткой привязки к конкретным классам объектов
- Необходимости изменять код при добавлении новых типов объектов
- Сложности создания объектов в зависимости от контекста

Метафоры из реального мира
- Фабрика игрушек: Один цех делает куклы, другой - машинки, но оба следуют стандарту производства
- Рестораны быстрого питания: Каждая точка общей сети готовит бургеры по-своему, но по общему стандарту

Потенциальные проблемы
-Усложнение кода: Нужно использовать только при необходимости в гибкости
- Требуется создание дополнительных классов
- Жесткая связь между создателем и продуктом
