# Sample: Public API Surface — net8.0

*Generated from .NET Aspire 13.3.0-dev packages using `dotnet-pkgs-ai-docs`*

This is an excerpt showing 5 packages. The full output contained 92 packages.

---

## Aspire.Azure.Data.Tables 13.3.0-dev

```
Aspire.Azure.Data.Tables.AzureDataTablesSettings (sealed class)
Aspire.Azure.Data.Tables.AzureDataTablesSettings.AzureDataTablesSettings() -> void
Aspire.Azure.Data.Tables.AzureDataTablesSettings.ConnectionString.get -> System.String
Aspire.Azure.Data.Tables.AzureDataTablesSettings.ConnectionString.set -> void
Aspire.Azure.Data.Tables.AzureDataTablesSettings.ServiceUri.get -> System.Uri
Aspire.Azure.Data.Tables.AzureDataTablesSettings.ServiceUri.set -> void
Microsoft.Extensions.Hosting.AspireTablesExtensions (static class)
```

---

## Aspire.Azure.Messaging.ServiceBus 13.3.0-dev

```
Aspire.Azure.Messaging.ServiceBus.AzureMessagingServiceBusSettings (sealed class)
Aspire.Azure.Messaging.ServiceBus.AzureMessagingServiceBusSettings.AzureMessagingServiceBusSettings() -> void
Aspire.Azure.Messaging.ServiceBus.AzureMessagingServiceBusSettings.ConnectionString.get -> System.String
Aspire.Azure.Messaging.ServiceBus.AzureMessagingServiceBusSettings.ConnectionString.set -> void
Aspire.Azure.Messaging.ServiceBus.AzureMessagingServiceBusSettings.FullyQualifiedNamespace.get -> System.String
Aspire.Azure.Messaging.ServiceBus.AzureMessagingServiceBusSettings.FullyQualifiedNamespace.set -> void
Microsoft.Extensions.Hosting.AspireServiceBusExtensions (static class)
```

---

## Aspire.Azure.Security.KeyVault 13.3.0-dev

```
Aspire.Azure.Security.KeyVault.AzureSecurityKeyVaultSettings (sealed class)
Aspire.Azure.Security.KeyVault.AzureSecurityKeyVaultSettings.AzureSecurityKeyVaultSettings() -> void
Aspire.Azure.Security.KeyVault.AzureSecurityKeyVaultSettings.VaultUri.get -> System.Uri
Aspire.Azure.Security.KeyVault.AzureSecurityKeyVaultSettings.VaultUri.set -> void
Microsoft.Extensions.Hosting.AspireKeyVaultExtensions (static class)
```

---

## Aspire.Confluent.Kafka 13.3.0-dev

```
Aspire.Confluent.Kafka.KafkaConsumerSettings (sealed class)
Aspire.Confluent.Kafka.KafkaConsumerSettings.Config.get -> Confluent.Kafka.ConsumerConfig
Aspire.Confluent.Kafka.KafkaConsumerSettings.ConnectionString.get -> System.String
Aspire.Confluent.Kafka.KafkaConsumerSettings.ConnectionString.set -> void
Aspire.Confluent.Kafka.KafkaConsumerSettings.DisableHealthChecks.get -> System.Boolean
Aspire.Confluent.Kafka.KafkaConsumerSettings.DisableHealthChecks.set -> void
Aspire.Confluent.Kafka.KafkaConsumerSettings.DisableMetrics.get -> System.Boolean
Aspire.Confluent.Kafka.KafkaConsumerSettings.DisableMetrics.set -> void
Aspire.Confluent.Kafka.KafkaConsumerSettings.DisableTracing.get -> System.Boolean
Aspire.Confluent.Kafka.KafkaConsumerSettings.DisableTracing.set -> void
Aspire.Confluent.Kafka.KafkaConsumerSettings.KafkaConsumerSettings() -> void
Aspire.Confluent.Kafka.KafkaProducerSettings (sealed class)
Aspire.Confluent.Kafka.KafkaProducerSettings.Config.get -> Confluent.Kafka.ProducerConfig
Aspire.Confluent.Kafka.KafkaProducerSettings.ConnectionString.get -> System.String
Aspire.Confluent.Kafka.KafkaProducerSettings.ConnectionString.set -> void
Aspire.Confluent.Kafka.KafkaProducerSettings.DisableHealthChecks.get -> System.Boolean
Aspire.Confluent.Kafka.KafkaProducerSettings.DisableHealthChecks.set -> void
Aspire.Confluent.Kafka.KafkaProducerSettings.DisableMetrics.get -> System.Boolean
Aspire.Confluent.Kafka.KafkaProducerSettings.DisableMetrics.set -> void
Aspire.Confluent.Kafka.KafkaProducerSettings.DisableTracing.get -> System.Boolean
Aspire.Confluent.Kafka.KafkaProducerSettings.DisableTracing.set -> void
Aspire.Confluent.Kafka.KafkaProducerSettings.KafkaProducerSettings() -> void
Microsoft.Extensions.Hosting.AspireKafkaConsumerExtensions (static class)
Microsoft.Extensions.Hosting.AspireKafkaProducerExtensions (static class)
```

---

## Aspire.Microsoft.Data.SqlClient 13.3.0-dev

```
Aspire.Microsoft.Data.SqlClient.MicrosoftDataSqlClientSettings (sealed class)
Aspire.Microsoft.Data.SqlClient.MicrosoftDataSqlClientSettings.ConnectionString.get -> System.String
Aspire.Microsoft.Data.SqlClient.MicrosoftDataSqlClientSettings.ConnectionString.set -> void
Aspire.Microsoft.Data.SqlClient.MicrosoftDataSqlClientSettings.DisableHealthChecks.get -> System.Boolean
Aspire.Microsoft.Data.SqlClient.MicrosoftDataSqlClientSettings.DisableHealthChecks.set -> void
Aspire.Microsoft.Data.SqlClient.MicrosoftDataSqlClientSettings.DisableTracing.get -> System.Boolean
Aspire.Microsoft.Data.SqlClient.MicrosoftDataSqlClientSettings.DisableTracing.set -> void
Aspire.Microsoft.Data.SqlClient.MicrosoftDataSqlClientSettings.MicrosoftDataSqlClientSettings() -> void
Microsoft.Extensions.Hosting.AspireSqlServerSqlClientExtensions (static class)
static Microsoft.Extensions.Hosting.AspireSqlServerSqlClientExtensions.AddKeyedSqlServerClient(Microsoft.Extensions.Hosting.IHostApplicationBuilder builder, System.String name, System.Action<Aspire.Microsoft.Data.SqlClient.MicrosoftDataSqlClientSettings> configureSettings) -> System.Void
static Microsoft.Extensions.Hosting.AspireSqlServerSqlClientExtensions.AddSqlServerClient(Microsoft.Extensions.Hosting.IHostApplicationBuilder builder, System.String connectionName, System.Action<Aspire.Microsoft.Data.SqlClient.MicrosoftDataSqlClientSettings> configureSettings) -> System.Void
```
