using Godot;
using System;

public partial class TournamentManager : Node
{
    public override void _Ready()
    {
        Participant anna = GetNode<Participant>("Anna");
        Participant janis = GetNode<Participant>("Janis");
        anna.Setup("Anna", 30);
        janis.Setup("Jānis", 20);

        anna.Finished += OnParticipantFinished;
        janis.Finished += OnParticipantFinished;

        anna.Finished -= OnParticipantFinished;

        anna.ApplyPenalty(10);
        anna.ApplyPenalty(20);
        anna.ApplyPenalty(5);
        janis.ApplyPenalty(20);

        GD.Print("Annas enerģija: ", anna.GetEnergy());
    }

    private void OnParticipantFinished(string participantName)
    {
        GD.Print(participantName, " izstājās");
    }
}
