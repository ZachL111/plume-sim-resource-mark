# plume-sim-resource-mark

`plume-sim-resource-mark` explores simulations with a small C# codebase and local fixtures. The technical goal is to create a C# reference implementation for resource workflows, centered on event replay, fixture event logs, and golden state snapshots.

## Project Rationale

This is intentionally local and self-contained so it can be inspected without credentials, services, or seeded history.

## Plume Sim Resource Mark Review Notes

The first comparison I would make is `input pressure` against `decision risk` because it shows where the rule is most opinionated.

## Feature Set

- `fixtures/domain_review.csv` adds cases for input pressure and state drift.
- `metadata/domain-review.json` records the same cases in structured form.
- `config/review-profile.json` captures the read order and the two review questions.
- `examples/plume-sim-resource-walkthrough.md` walks through the case spread.
- The C# code includes a review path for `input pressure` and `decision risk`.
- `docs/field-notes.md` explains the strongest and weakest cases.

## Architecture

The fixture data drives the tests. The code stays thin, while `metadata/domain-review.json` and `config/review-profile.json` explain what each case is meant to protect.

The C# code keeps the review rule close to the tests.

## Usage

```powershell
powershell -NoProfile -ExecutionPolicy Bypass -File scripts/verify.ps1
```

## Test Command

That command is also the regression path. It verifies the domain cases and catches mismatches between the CSV, metadata, and code.

## Next Improvements

No external service is required. A deeper version would add more negative cases and a clearer boundary around invalid input.
