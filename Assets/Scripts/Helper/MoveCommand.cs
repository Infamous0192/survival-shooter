public class MoveCommand: Command {
  PlayerMovement playerMovement;
  float h, v;

  public MoveCommand(PlayerMovement _playerMovement, float _h, float _v) {
    this.playerMovement = _playerMovement;
    this.h = _h;
    this.v = _v;
  }

  public override void Execute() {
    playerMovement.Move(h, v);

    playerMovement.Animating(h, v);
  }

  public override void UnExecute() {
    playerMovement.Move(-h, -v);

    playerMovement.Animating(h, v);
  }
}