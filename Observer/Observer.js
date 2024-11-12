class Subject {
    constructor() {
        this.observers = [];
    }

    attach(observer) {
        this.observers.push(observer);
    }

    detach(observer) {
        const index = this.observers.indexOf(observer);
        if (index >= 0) {  // Corrección de la condición
            this.observers.splice(index, 1);
        }
    }

    notify() {
        for (let observer of this.observers) {
            observer.update();
        }
    }
}

class ConcreteSubject extends Subject {
    constructor() {
        super();
        this.state = null;
    }

    getState() {
        return this.state;
    }

    setState(state) {
        this.state = state;
        this.notify();
    }
}

class Observer {
    update() {
        throw new Error("Este método debe ser sobrescrito.");
    }
}

class ConcreteObserver extends Observer {
    constructor(subject, name) {
        super();
        this.subject = subject;
        this.name = name;
    }

    update() {  // Corrección del nombre del método
        console.log("Notificar a: " + this.name + ", Cambio el estado a : " + this.subject.getState());
    }
}

class Main {
    constructor() {
        const subject = new ConcreteSubject();
        const observer1 = new ConcreteObserver(subject, "Brayan Medina");
        const observer2 = new ConcreteObserver(subject, "Juan Figueroa");

        subject.attach(observer1);
        subject.attach(observer2);

        subject.setState("Cambio");
        
        subject.setState("Otro Cambio");
    }
}

new Main();
