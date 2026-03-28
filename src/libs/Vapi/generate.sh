#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://api.vapi.ai/api-json

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error --location https://api.vapi.ai/api-json -o openapi.yaml

autosdk generate openapi.yaml \
  --namespace Vapi \
  --clientClassName VapiClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
