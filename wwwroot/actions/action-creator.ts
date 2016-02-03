class ActionCreator {
    constructor(private dispatcher) { }

    play = videoId => this.dispatcher.dispatch(new PlayVideoAction(videoId));

}