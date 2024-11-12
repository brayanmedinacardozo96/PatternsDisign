// Interface Observer
interface Observer {
    update(): void;
}

// Clase Subject
class Subject {
    private observers: Observer[] = [];

    attach(observer: Observer): void {
        this.observers.push(observer);
    }

    detach(observer: Observer): void {
        const index = this.observers.indexOf(observer);
        if (index >= 0) {
            this.observers.splice(index, 1);
        }
    }

    notify(): void {
        for (let observer of this.observers) {
            observer.update();
        }
    }
}

// Clase ConcreteSubject que extiende de Subject
class ConcreteSubject extends Subject {
    private state: any = null;

    getState(): any {
        return this.state;
    }

    setState(state: any): void {
        this.state = state;
        this.notify();
    }
}

// Clase Observer con el método abstracto update
abstract class BaseObserver implements Observer {
    abstract update(): void;
}

// Clase ConcreteObserver que implementa la interfaz Observer
class ConcreteObserver extends BaseObserver {
    private subject: ConcreteSubject;
    private name: string;

    constructor(subject: ConcreteSubject, name: string) {
        super();
        this.subject = subject;
        this.name = name;
    }

    update(): void {
        console.log(`Notificar a: ${this.name}, cambio el estado a ${this.subject.getState()}`);
    }
}

// Clase Main para ejecutar el código
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

// Ejecuta
new Main();
